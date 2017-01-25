using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrganizationInfo.DataManagers;

namespace OrganizationInfo
{
    public partial class UpdateDepartment : Form
    {
        private IdInformation Ids;
        private IDepartmentDataManager ddm = new DepartmentDataManager();
        public UpdateDepartment(object tag)
        {
            InitializeComponent();
            Ids = (IdInformation)tag;
            Department department = ddm.Get(Ids);
            DepartmentName.Text = department.Name;
            Address.Text = department.Address;
            MaxNumberOfEmployees.Text = department.MaxNumberOfEmployees.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Department department = ddm.Get(Ids);
            department.Name = DepartmentName.Text;
            department.Address = Address.Text;
            department.MaxNumberOfEmployees = int.Parse(MaxNumberOfEmployees.Text);
            ddm.Update(department);
            Close();
        }
    }
}
