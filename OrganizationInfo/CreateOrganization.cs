using System;
using System.Windows.Forms;

namespace OrganizationInfo
{
    public partial class CreateOrganization : Form
    {
        public CreateOrganization()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            AddOrganization();
        }

        private void AddOrganization()
        {
            if (Check())
            {
                Organization organization = new Organization(OrganizationName.Text, OrganizationLegalAddress.Text);
                var odm = new DataManagers.OrganizationDataManager();
                odm.Add(organization);
                Close();
            }
            else
            {
                MessageBox.Show("Организация не была добавлена, введите корректные данные и попробуйте ещё раз.");
            }
        }

        private bool Check()
        {

            if (OrganizationName.Text == null || OrganizationName.Text.Contains(":")) 
            {
                MessageBox.Show("Название не может быть пустым или содержать двоеточие");
                return false;
            }

            if (OrganizationLegalAddress.Text == null)
            {
                MessageBox.Show("Введите адрес!");
                return false;
            }
            return true;
        }
    }
}
