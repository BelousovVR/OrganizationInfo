using OrganizationInfo.DataManagers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OrganizationInfo
{
    public partial class AddNewEmployee : Form
    {
        private IdInformation Ids;

        public AddNewEmployee(object tag)
        {
            InitializeComponent();
            Ids = (IdInformation)tag;
        }

        // TODO: комментарии
        private void Add_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        // TODO: комментарии
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // TODO: комментарии
        private void AddNew()
        {
            if (Check())
            {
                Employee employee = new Employee(Ids.OrganizationId, Ids.DepartmentId, EmployeeName.Text, TaxNumber.Text, Post.Text, int.Parse(Salary.Text));
                // TODO: DataManager можно сделать свойством формы и создавать в конструкторе
                var edm = new EmployeeDataManager();
                edm.Add(employee);
                Close();
            }
            else
            {
                MessageBox.Show("Сотрудник не был добавлен, введите корректные данные и попробуйте ещё раз");
            }
        }

        // TODO: комментарии
        // TODO: IsEmployeeInputValid
        private bool Check()
        {
            // TODO: string.IsNullOrEmpty
            if (EmployeeName.Text == null || Valid(EmployeeName.Text, "Letters"))
            {
                MessageBox.Show("Имя не может быть пустым и может содержать только буквы");
                return false;
            }

            if (string.IsNullOrEmpty(TaxNumber.Text) || Valid(TaxNumber.Text, "Digits"))
            {
                MessageBox.Show("Инн не может быть пустым и может содержать только цифры");
                return false;
            }

            if(string.IsNullOrEmpty(Post.Text))
            {
                MessageBox.Show("Введите должность");
                return false;
            }

            if (string.IsNullOrEmpty(Salary.Text)|| Valid(Salary.Text, "Digits"))
            {
                MessageBox.Show("Заработная плата не может быть пустой и может содержать только цифры");
                return false;
            }
            return true;
        }

        // TODO: комментарии
        // TODO: по логике Valid должен возвращать true в случае, если все хорошо, а у тебя наоборот
        // TODO: надо сделать метод IsContainsOnlyLetters
        // А для случая с цифрами просто сделать int.TryParse (если считать, что ЗП не может быть дробной)
        private bool Valid(string text, string compareCondition)
        {
            if (compareCondition=="Letters")
            {
                var notLetters = from simbol in text
                                 where !char.IsLetter(simbol)
                                 select simbol;
                if (notLetters != null)
                    return false;
                else
                    return true;
            }
            else
            {
                var notDigits = from simbol in text
                                where !char.IsDigit(simbol)
                                select simbol;
                if (notDigits != null)
                    return false;
                else
                    return true;
            }
        }

    }
}
