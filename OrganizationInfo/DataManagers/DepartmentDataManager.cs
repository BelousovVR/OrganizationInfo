using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OrganizationInfo.DataManagers
{
    public class DepartmentDataManager : IDepartmentDataManager
    {
        private IEmployeeDataManager employeeDataManager = new EmployeeDataManager();

        /// <summary>
        /// Переводим экземпляр отдела в строку и записываем в файл
        /// </summary>
        /// <param name="department"></param>
        /// экземпляр отдела
        /// <returns></returns>
        /// возвращаем новый id 
        public void Add(Department department)
        {
            var id = GetAll().Max(l => l.Id) + 1;
            department.Id = id;
            var departmentString = DepartmentToString(department);
            AppendDepartmentInFile(departmentString);
        }

        /// <summary>
        /// Удаляем отдел и всех его сотрудников из файлов
        /// </summary>
        /// <param name="department"></param>
        /// экземпляр отдела
        public void Delete(Department department)
        {
            DeleteEmployees(department);
            ReWriteDepartments(GetDepartmentsWithoutSelected(department));
        }

        public void DeleteEmployees(Department department)
        {
            foreach (var employee in department.Employees)
            {
                employeeDataManager.Delete(employee);
            }
        }

        /// <summary>
        /// Получаем экземпляр отдела по id
        /// </summary>
        /// <param name="id"></param>
        /// id
        /// <returns></returns>
        /// экземпляр отдела
        public Department Get(IdInformation Ids)
        {
            var department = GetAll()
                .Where(l => l.Id == Ids.DepartmentId && l.OrganizationID==Ids.OrganizationId)
                .Select(l => l)
                .SingleOrDefault();

            if (department == null)
                return null;

            department.Employees = employeeDataManager.GetAllByDepartmentId(new IdInformation(department.OrganizationID, department.Id));

            return department;
        }

        /// <summary>
        /// Получаем список всех отделов в файле
        /// </summary>
        /// <returns></returns>
        /// список отделов
        public List<Department> GetAll()
        {
            return GetAllLines()
                .Select(l => StringToDepartment(l))
                .ToList();
        }

        /// <summary>
        /// Обновляем информацию об отделе(имя, адрес, вместимость)
        /// </summary>
        /// <param name="department"></param>
        /// экземпляр отдела
        public void Update(Department department)
        {
            var departments = GetDepartmentsWithoutSelected(department);
            departments.Add(department);
            ReWriteDepartments(departments);
        }

        /// <summary>
        /// Получаем список отделов по id организации
        /// </summary>
        /// <param name="organizationId"></param>
        /// id организации
        /// <returns></returns>
        /// список отделов
        public List<Department> GetAllByOrganizationId(int? organizationId)
        {
            return GetAllLines()
                .Select(l => StringToDepartment(l))
                .Where(l => l.OrganizationID == organizationId)
                .Select(l => Get(new IdInformation(l.OrganizationID, l.Id)))
                .ToList();
        }

        /// <summary>
        /// Считываем все строки в файле
        /// </summary>
        /// <returns></returns>
        /// массив строк
        private string[] GetAllLines()
        {
            using (var sr = new StreamReader(PathStorage.PathToDepartments))
            {
                return sr.ReadToEnd()
                    .Replace("\n", "")
                    .Split('\r')
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .ToArray();
            }
        }

        /// <summary>
        /// Перезапись файла
        /// </summary>
        /// <param name="departments"></param>
        /// список отделов
        private void ReWriteDepartments(List<Department> departments)
        {
            File.Delete(PathStorage.PathToDepartments);
            using (FileStream fs = File.Create(PathStorage.PathToDepartments))
            {

            }
            foreach (var department in departments)
            {
                string text = DepartmentToString(department);
                AppendDepartmentInFile(text);
            }
        }

        /// <summary>
        /// Перевод экземпляра отдела в строковое представление
        /// </summary>
        /// <param name="department"></param>
        /// экземпляр отдела
        /// <returns></returns>
        /// строка
        public string DepartmentToString(Department department)
        {
            return $"\r\n{department.OrganizationID} {department.Id} {department.Name} {department.Address} {department.MaxNumberOfEmployees}\r\n";
        }

        /// <summary>
        /// Перевод строки в экземпляр отдела
        /// </summary>
        /// <param name="stringRepresentationForDepartment"></param>
        /// строка
        /// <returns></returns>
        /// экземпляр отдела
        public Department StringToDepartment(string stringRepresentationForDepartment)
        {
            var data = stringRepresentationForDepartment.Split(' ');

            var organizationId = int.Parse(data[0]);
            var Id = int.Parse(data[1]);
            var name = data[2];
            var address = data[3];
            var maxNumberOfEmployees = int.Parse(data[4]);

            Department department = new Department(organizationId, Id, name, address, maxNumberOfEmployees);
            return department;
        }

        /// <summary>
        /// Добавление строкового представления в файл
        /// </summary>
        /// <param name="stringRepresentationForDepartment"></param>
        /// строка
        private void AppendDepartmentInFile(string stringRepresentationForDepartment)
        {
            using (Stream stream = File.Open(PathStorage.PathToDepartments, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(stringRepresentationForDepartment);
                }
            }
        }

        /// <summary>
        /// Выбор списка без 1 участника = удаление
        /// </summary>
        /// <param name="department"></param>
        /// экземпляр отдела
        /// <returns></returns>
        /// новый список
        private List<Department> GetDepartmentsWithoutSelected(Department department)
        {
            return GetAllLines()
                .Select(l => StringToDepartment(l))
                .Where(l => l.Id != department.Id)
                .ToList();
        }
    }
}
