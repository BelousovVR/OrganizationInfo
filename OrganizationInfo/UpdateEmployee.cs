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
    public partial class UpdateEmployee : Form
    {
        private IdInformation Ids;
        private IEmployeeDataManager edm = new EmployeeDataManager();
        public UpdateEmployee(object tag)
        {
            InitializeComponent();
            Ids = (IdInformation)tag;
            Employee employee = edm.Get(Ids);
            EmployeeName.Text = employee.Name;
            TaxNumber.Text = employee.IndividualTaxNumber;
            Post.Text = employee.Post;
            Salary.Text = employee.Salary.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Employee employee = edm.Get(Ids);
            employee.Name = EmployeeName.Text;
            employee.IndividualTaxNumber = TaxNumber.Text;
            employee.Post = Post.Text;
            employee.Salary = int.Parse(Salary.Text);
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
