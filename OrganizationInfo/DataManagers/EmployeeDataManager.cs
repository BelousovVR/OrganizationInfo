using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OrganizationInfo.DataManagers
{
    public class EmployeeDataManager : IEmployeeDataManager
    {
        /// <summary>
        /// Переводим наш экземпляр "сотрудника" в строку и записываем в файл
        /// </summary>
        /// <param name="employee"></param> 
        /// экземпляр сотрудника, которого надо добавить
        public void Add(Employee employee)
        {
            var id = GetAll().Max(l => l.Id) + 1;
            employee.Id = id;
            var employeeString = EmployeeToString(employee);
            AppendEmployeeInFile(employeeString);
        }

        /// <summary>
        /// Переписываем файл так, чтобы в нашем файле не было выбранного сотрудника = удаление
        /// </summary>
        /// <param name="employee"></param> 
        /// экземпляр сотрудника, который нам надо удалить
        public void Delete(Employee employee)
        {
            ReWriteEmployees(GetEmployeesWithoutSelected(employee));
        }

        /// <summary>
        /// Заменяем экземпляр сотрудника с таким же id как у нас на другой = обновили информацию о сотруднике
        /// </summary>
        /// <param name="employee"></param>
        /// экземпляр сотрудника, которого надо обновить
        public void Update(Employee employee)
        {
            var employees = GetEmployeesWithoutSelected(employee);
            employees.Add(employee);
            ReWriteEmployees(employees);
        }

        /// <summary>
        /// Получение сотрудника по id
        /// </summary>
        /// <param name="id"></param>
        /// id сотрудника
        /// <returns></returns>
        /// экземпляр сотрудника, если такой есть
        public Employee Get(IdInformation Ids)
        {
            var employee = GetAll()
                .Where(l => l.Id == Ids.EmployeeId)
                .Select(l => l)
                .SingleOrDefault();
            if (employee == null)
                return null;
            return employee;
        }

        /// <summary>
        /// Переводим строковое представление нашего сотрудника в экземпляр Employee
        /// </summary>
        /// <param name="line"></param>
        /// строковое представление сотрудника
        /// <returns></returns>
        /// экземпляр сотрудника
        private Employee StringToEmployee(string employeeStringData)
        {
            var data = employeeStringData.Split(' ');

            var organizationId = int.Parse(data[0]);
            var departmentId = int.Parse(data[1]);
            var Id = int.Parse(data[2]);
            var name = data[3];
            var taxNumber = data[4];
            var post = data[5];
            var salary = int.Parse(data[6]);

            Employee employee = new Employee(organizationId, departmentId, Id, name, taxNumber, post, salary);
            return employee;
        }

        /// <summary>
        /// Получаем список всех существующих сотрудников
        /// </summary>
        /// <returns></returns>
        /// список сотрудников
        public List<Employee> GetAll()
        {
            return GetAllLines()
                .Select(l => StringToEmployee(l))
                .ToList();
        }

        /// <summary>
        /// Переводим наш экземпляр сотрудника в строковое представление
        /// </summary>
        /// <param name="employee"></param>
        /// экземпляр сотрудника
        /// <returns></returns>
        /// строковое представление
        private string EmployeeToString(Employee employee)
        {
            return $"\r\n{employee.OrganizationID} {employee.DepartmentID } {employee.Id} {employee.Name} {employee.IndividualTaxNumber} {employee.Post} {employee.Salary}";
        }

        /// <summary>
        /// Получаем всех сотрудников из заданного департамента по id
        /// </summary>
        /// <param name="departmentId"></param>
        /// id отдела 
        /// <returns></returns>
        /// список сотрудников отдела
        public List<Employee> GetAllByDepartmentId(IdInformation Ids)
        {
            return GetAllLines()
                .Select(l => StringToEmployee(l))
                .Where(l => l.DepartmentID == Ids.DepartmentId && l.OrganizationID == Ids.OrganizationId)
                .ToList();
        }

        /// <summary>
        /// Получаем всех сотрудников без отдела из заданной организации по id
        /// </summary>
        /// <param name="id"></param>
        /// id организации
        /// <returns></returns>
        /// список сотрудников организации без отдела
        public List<Employee> GetAllWithoutDepartment(int? organizationId)
        {
            return GetAllLines()
                .Select(l => StringToEmployee(l))
                .Where(l => l.OrganizationID == organizationId && l.DepartmentID == 0)
                .ToList();
        }

        /// <summary>
        /// Получаем всех сотрудников организации по её id
        /// </summary>
        /// <param name="organizationId"></param>
        /// id организации
        /// <returns></returns>
        /// список сотрудников
        public List<Employee> GetAllByOrganizationId(int? organizationId)
        {
            return GetAllLines()
                .Select(l => StringToEmployee(l))
                .Where(l => l.OrganizationID == organizationId)
                .ToList();
        }

        /// <summary>
        /// Получаем все строки из файла
        /// </summary>
        /// <returns></returns>
        /// массив строк
        private string[] GetAllLines()
        {
            using (var sr = new StreamReader(PathStorage.PathToEmployees))
            {
                return sr.ReadToEnd()
                    .Replace("\n", "")
                    .Split('\r')
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .ToArray();
            }
        }

        /// <summary>
        /// Полностью перезаписываем данные в файле
        /// </summary>
        /// <param name="employees"></param>
        /// список сотрудников
        private void ReWriteEmployees(List<Employee> employees)
        {
            File.Delete(PathStorage.PathToEmployees);
            using (FileStream fs = File.Create(PathStorage.PathToEmployees))
            {

            }
            foreach (var employee in employees)
            {
                string text = EmployeeToString(employee);
                AppendEmployeeInFile(text);
            }
        }

        /// <summary>
        /// Добавляем строковое представление сотрудника в конец файла
        /// </summary>
        /// <param name="stringRepresentationForEmployee"></param>
        /// строковое представление сотрудника
        private void AppendEmployeeInFile(string stringRepresentationForEmployee)
        {
            using (Stream stream = File.Open(PathStorage.PathToEmployees, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(stringRepresentationForEmployee);
                }
            }
        }

        /// <summary>
        /// Получаем список всех сотрудников без указанного
        /// </summary>
        /// <param name="employee"></param>
        /// сотрудник, который нам в этом списке не нужен
        /// <returns></returns>
        /// обновленный список сотрудников
        private List<Employee> GetEmployeesWithoutSelected(Employee employee)
        {
            return GetAllLines()
                .Select(l => StringToEmployee(l))
                .Where(l => l.Id != employee.Id)
                .ToList();
        }
    }
}
