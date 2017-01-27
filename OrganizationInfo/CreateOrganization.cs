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

        // TODO: комментарии
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // TODO: комментарии
        private void Create_Click(object sender, EventArgs e)
        {
            AddOrganization();
        }

        // TODO: комментарии
        private void AddOrganization()
        {
            if (Check())
            {
                Organization organization = new Organization(OrganizationName.Text, OrganizationLegalAddress.Text);

                // TODO: можно сделать свойством формы и инициализировать в конструкторе
                var odm = new DataManagers.OrganizationDataManager();

                odm.Add(organization);
                Close();
            }
            else
            {
                MessageBox.Show("Организация не была добавлена, введите корректные данные и попробуйте ещё раз.");
            }
        }

        // TODO: комментарии
        // TODO: IsOrganizationInputValid
        private bool Check()
        {
            // TODO: string.IsNullOrEmpty
            if (OrganizationName.Text == null || OrganizationName.Text.Contains(":")) 
            {
                MessageBox.Show("Название не может быть пустым или содержать двоеточие");
                return false;
            }

            // TODO: string.IsNullOrEmpty
            if (OrganizationLegalAddress.Text == null)
            {
                MessageBox.Show("Введите адрес!");
                return false;
            }
            return true;
        }
    }
}
