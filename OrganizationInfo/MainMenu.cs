using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OrganizationInfo.DataManagers;

namespace OrganizationInfo
{
    public partial class MainMenu : Form
    {
        private IOrganizationDataManager organizationDataManager = new OrganizationDataManager();
        private IDepartmentDataManager departmentDataManager = new DepartmentDataManager();
        private IEmployeeDataManager employeeDataManager = new EmployeeDataManager();
        public List<Organization> organizations = new List<Organization>();

        public MainMenu()
        {
            InitializeComponent();

            OrganizationsStructure.BeforeSelect += OrganizationsStructure_BeforeSelect;
            OrganizationsStructure.NodeMouseClick += OrganizationsStructure_NodeMouseClick;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            RefreshFormData();
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshFormData()
        {
            OrganizationsStructure.Nodes.Clear();
            organizations = organizationDataManager.GetAll();
            FillingOrganizationTreeView.FillingOrgs(organizations, OrganizationsStructure);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrganizationsStructure_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            IdInformation Ids = (IdInformation)e.Node.Tag;
            ContextMenuStrip menu = new ContextMenuStrip();
            var addNewOrganization = FillToolStripItem("Add new organization", Ids);
            var addNewDepartment = FillToolStripItem("Add new department", Ids);
            var addNewEmployee = FillToolStripItem("Add new employee", Ids);
            var delete = FillToolStripItem("Delete", Ids);
            var change = FillToolStripItem("Change", Ids);

            menu.Items.AddRange(new ToolStripMenuItem[]{addNewOrganization, addNewDepartment, addNewEmployee, delete, change});

            e.Node.ContextMenuStrip = menu;
            
            addNewOrganization.Click += AddNewOrganization_Click;
            addNewDepartment.Click += AddNewDepartment_Click;
            addNewEmployee.Click += AddNewEmployee_Click;
            delete.Click += Delete_Click;
            change.Click += Change_Click;
            this.Controls.Add(OrganizationsStructure);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Ids"></param>
        /// <returns></returns>
        private ToolStripMenuItem FillToolStripItem(string name, IdInformation Ids)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = name;
            item.Tag = Ids;
            return item;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewOrganization_Click(object sender, EventArgs e)
        {
            CreateOrganization co = new CreateOrganization();
            ClickActions(co);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewDepartment_Click(object sender, EventArgs e)
        {
            AddNewDepartment adn = new AddNewDepartment(((ToolStripMenuItem)sender).Tag);
            ClickActions(adn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployee ane = new AddNewEmployee(((ToolStripMenuItem)sender).Tag);
            ClickActions(ane);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="form"></param>
        private void ClickActions(Form form)
        {
            form.ShowDialog();
            RefreshFormData();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            var Ids = (IdInformation)((ToolStripMenuItem)sender).Tag;

            if (Ids.DepartmentId != null && Ids.DepartmentId > 0)
            {
                if (Ids.EmployeeId != null)
                {
                    UpdateEmployee ue = new UpdateEmployee(Ids);
                    ClickActions(ue);
                }
                UpdateDepartment ud = new UpdateDepartment(Ids);
                ClickActions(ud);
            }
            else
            {
                UpdateOrganization uo = new UpdateOrganization(Ids);
                ClickActions(uo);
            }
        }

        //TODO: разбить на методы
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, EventArgs e)
        {
            var Ids = (IdInformation)((ToolStripMenuItem)sender).Tag;
            foreach (var organization in organizations)
            {
                if (organization.Id == Ids.OrganizationId)
                {
                    if (Ids.DepartmentId != null) 
                    {
                        if (Ids.DepartmentId == -1) 
                        {
                            foreach(var department in organization.Departments)
                            {
                                departmentDataManager.Delete(department);
                            }
                            break;
                        }
                        if (Ids.DepartmentId == 0)
                        {
                            foreach(var employee in organization.Employees)
                            {
                                employeeDataManager.Delete(employee);
                            }
                            break;
                        }
                        if (Ids.DepartmentId > 0)
                        {
                            if (Ids.EmployeeId != null)
                            {
                                if (Ids.EmployeeId == 0)
                                {
                                    foreach (var employee in departmentDataManager.Get(Ids).Employees)
                                    {
                                        employeeDataManager.Delete(employee);
                                    }
                                    break;
                                }
                                else
                                {
                                    employeeDataManager.Delete(employeeDataManager.Get(Ids));
                                    break;
                                }
                            }
                            else
                            {
                                departmentDataManager.Delete(departmentDataManager.Get(Ids));
                                break;
                            }
                        }
                    }
                    else
                    {
                        organizationDataManager.Delete(organization);
                        break;
                    }
                }
            }
            RefreshFormData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrganizationsStructure_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            var path = e.Node.FullPath.Split('\\');
            listBox1.Items.Clear();

            foreach (var org in organizations)
            {
                if (org.Name == path[0])
                {
                    WriteOrganization(org);

                    if (path.Length > 2)
                    {
                        listBox1.Items.Clear();
                        foreach(var dep in org.Departments)
                        {
                            if (dep.Name == path[2])
                            {
                                WriteDepartment(dep);
                            }
                            if (path.Length == 5)
                            {
                                listBox1.Items.Clear();
                                foreach(var emp in dep.Employees)
                                {
                                    if (emp.Name == path[4])
                                    {
                                        WriteEmployee(emp);
                                        return;
                                    }
                                }
                            }
                        }
                        foreach(var emp in org.Employees)
                        {
                            if (emp.Name==path[2])
                            {
                                listBox1.Items.Clear();
                                WriteEmployee(emp);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="org"></param>
        private void WriteOrganization(Organization org)
        {
            listBox1.Items.Add("Название организации:                " + org.Name);
            listBox1.Items.Add("Адрес                                " + org.LegalAddress);
            listBox1.Items.Add("Количество работников:               " + org.QuantityOfEmployees);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dep"></param>
        private void WriteDepartment(Department dep)
        {
            listBox1.Items.Add("Название отдела:                     " + dep.Name);
            listBox1.Items.Add("Местоположение:                      " + dep.Address);
            listBox1.Items.Add("Максимальное количество работников:  " + dep.MaxNumberOfEmployees);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emp"></param>
        private void WriteEmployee(Employee emp)
        {
            listBox1.Items.Add("Имя:                                 " + emp.Name);
            listBox1.Items.Add("ИНН:                                 " + emp.IndividualTaxNumber);
            listBox1.Items.Add("Должность:                           " + emp.Post);
            listBox1.Items.Add("Заработная плата:                    " + emp.Salary);
        }
    }
}
