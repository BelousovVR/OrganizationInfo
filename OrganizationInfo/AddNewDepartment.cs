using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using OrganizationInfo.DataManagers;

namespace OrganizationInfo
{
    public partial class AddNewDepartment : Form
    {
        private IdInformation Ids;

        public AddNewDepartment(object tag)
        {
            InitializeComponent();
            Ids = (IdInformation)tag;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            if (Check())
            {
                DepartmentDataManager ddm = new DepartmentDataManager();
                Department department = new Department(Ids.OrganizationId, DepartmentName.Text, Address.Text, int.Parse(MaxNumberOfEmployees.Text));
                ddm.Add(department);
                Close();
            }
            else
            {
                MessageBox.Show("Отдел не был добавлен, введите корректные данные и попробуйте ещё раз");
            }
        }

        private bool Check()
        {
            try
            {
                int.Parse(MaxNumberOfEmployees.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректное число сотрудников");
                return false;
            }

            if (int.Parse(MaxNumberOfEmployees.Text) == 0 || MaxNumberOfEmployees.Text == null)
            {
                MessageBox.Show("Некорректное число сотрудников");
                return false;
            }

            if (DepartmentName.Text == null || DepartmentName.Text.Contains(":"))
            {
                MessageBox.Show("Название не может быть пустым и не может содержать двоеточие.");
                return false;
            }

            if (Address.Text == null)
            {
                MessageBox.Show("Введите адрес!");
                return false;
            }
            return true;
        }
    }
}
