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
    public partial class UpdateOrganization : Form
    {
        private IdInformation Ids;
        private IOrganizationDataManager odm = new OrganizationDataManager();
        public UpdateOrganization(object tag)
        {
            InitializeComponent();
            Ids = (IdInformation)tag;
            Organization organization = odm.Get(Ids);
            OrganizationName.Text = organization.Name;
            OrganizationLegalAddress.Text = organization.LegalAddress;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Organization organization = odm.Get(Ids);
            organization.Name = OrganizationName.Text;
            organization.LegalAddress = OrganizationLegalAddress.Text;
            odm.Update(organization);
            Close();
        }
    }
}
