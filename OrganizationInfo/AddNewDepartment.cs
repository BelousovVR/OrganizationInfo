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

        // TODO: комментарии
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // TODO: комментарии
        private void Add_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        // TODO: комментарии
        private void AddNew()
        {
            if (Check())
            {
                // TODO: DepartmentDataManager можно сделать свойством и создавать в конструкторе формы
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


        // TODO: комментарии
        // TODO: IsDepartmentInputValid
        private bool Check()
        {

            // TODO: TryParse и никакого перехвата исключений не понадобится
            try
            {
                int.Parse(MaxNumberOfEmployees.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректное число сотрудников");
                return false;
            }
            //

            // TODO: повторяется int.Parse(MaxNumberOfEmployees.Text)
            // а вообще сначала следует проверить строки на пустоту: string.NullOrEmpty(MaxNumberOfEmployees.Text)
            if (int.Parse(MaxNumberOfEmployees.Text) == 0 || MaxNumberOfEmployees.Text == null)
            {
                MessageBox.Show("Некорректное число сотрудников");
                return false;
            }

            // TODO: сначала следует проверить строки на пустоту: string.NullOrEmpty(DepartmentName.Text)
            if (DepartmentName.Text == null || DepartmentName.Text.Contains(":"))
            {
                MessageBox.Show("Название не может быть пустым и не может содержать двоеточие.");
                return false;
            }

            // TODO: сначала следует проверить строки на пустоту: string.NullOrEmpty(Address.Text)
            if (Address.Text == null)
            {
                MessageBox.Show("Введите адрес!");
                return false;
            }
            return true;
        }
    }
}
