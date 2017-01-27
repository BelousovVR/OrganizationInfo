using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace OrganizationInfo.DataManagers
{
    public class OrganizationDataManager : IOrganizationDataManager
    {
        // TODO: для юнит -тестов должно быть открытое свойство
        private IEmployeeDataManager employeeDataManager = new EmployeeDataManager();

        // TODO: для юнит -тестов должно быть открытое свойство
        private IDepartmentDataManager departmnetDataManager = new DepartmentDataManager();

        // TODO: неверный формат комментариев
        /// <summary>
        /// Переводим экземпляр организации в строку и записываем в файл
        /// </summary>
        /// <param name="organization"></param>
        /// экземпляр организации
        /// <returns></returns>
        /// возвращаем новый id 
        public void Add(Organization organization)
        {
            // TODO: в метод и в базовый класс
            var id = GetAll().Max(l => l.Id) + 1;
            //
            organization.Id = id;
            var organizationString = OrganizationToString(organization);
            AppendOrganizationInFile(organizationString);
        }

        // TODO: неверный формат комментариев
        /// <summary>
        /// Удаляем организацию и всех его сотрудников из файлов
        /// </summary>
        /// <param name="organization"></param>
        /// экземпляр организации
        public void Delete(Organization organization)
        {
            DeleteEmployees(organization);
            DeleteDepartments(organization);
            ReWriteOrganizations(GetOrganizationsWithoutSelected(organization));
        }

        // TODO: комментарии
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organization"></param>
        public void DeleteEmployees(Organization organization)
        {
            foreach (var employee in organization.Employees)
            {
                employeeDataManager.Delete(employee);
            }
        }

        // TODO: комментарии
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organization"></param>
        public void DeleteDepartments(Organization organization)
        {
            foreach (var department in organization.Departments)
            {
                departmnetDataManager.Delete(department);
            }
        }

        // TODO: неверный формат комментариев
        /// <summary>
        /// Получаем экземпляр организации по id
        /// </summary>
        /// <param name="id"></param>
        /// id
        /// <returns></returns>
        /// экземпляр организации
        public Organization Get(IdInformation Ids)
        {
            var organization = GetAllLines()
                .Select(l => StringToOrganization(l))
                .Where(l => l.Id == Ids.OrganizationId)
                .SingleOrDefault();

            if (organization == null)
                return null;

            organization.Employees = employeeDataManager.GetAllWithoutDepartment(organization.Id);
            organization.Departments = departmnetDataManager.GetAllByOrganizationId(organization.Id);

            return organization;
        }

        /// <summary>
        /// Получаем список всех организаций в файле
        /// </summary>
        /// <returns></returns>
        /// список организаций
        public List<Organization> GetAll()
        {
            var organizations = GetAllLines()
                .Select(l => StringToOrganization(l))
                .ToList();
            foreach(var organization in organizations)
            {
                organization.Employees = employeeDataManager.GetAllWithoutDepartment(organization.Id);
                organization.Departments = departmnetDataManager.GetAllByOrganizationId(organization.Id);
            }
            return organizations;
        }

        /// <summary>
        /// Обновляем информацию об организации(имя, адрес)
        /// </summary>
        /// <param name="organization"></param>
        /// экземпляр организации
        public void Update(Organization organization)
        {
            var organizations = GetOrganizationsWithoutSelected(organization);
            organizations.Add(organization);
            ReWriteOrganizations(organizations);
        }

        // TODO: неверный формат комментариев
        // TODO: в DepartmentDataManager писал как можно упростить
        /// <summary>
        /// Считываем все строки в файле
        /// </summary>
        /// <returns></returns>
        /// массив строк
        private string[] GetAllLines()
        {
            using (var sr = new StreamReader(PathStorage.PathToOrganizations))
            {
                string[] lines = sr.ReadToEnd()
                    .Replace("\n", "")
                    .Split('\r')
                    .Where(l => !string.IsNullOrWhiteSpace(l))
                    .ToArray();
                sr.Close();
                return lines;
            }
        }

        // TODO: неверный формат комментариев
        // TODO: в DepartmentDataManager писал как можно упростить
        /// <summary>
        /// Перезапись файла
        /// </summary>
        /// <param name="organizations"></param>
        /// список организаций
        private void ReWriteOrganizations(List<Organization> organizations)
        {
            File.Delete(PathStorage.PathToOrganizations);
            using (FileStream fs = File.Create(PathStorage.PathToOrganizations))
            {

            }
            foreach (var organization in organizations)
            {
                string text = OrganizationToString(organization);
                AppendOrganizationInFile(text);
            }
        }

        // TODO: неверный формат комментариев
        /// <summary>
        /// Перевод экземпляра организации в строковое представление
        /// </summary>
        /// <param name="organization"></param>
        /// экземпляр организации
        /// <returns></returns>
        /// строка
        public string OrganizationToString(Organization organization)
        {
            return $"\r\n{organization.Id} {organization.Name} {organization.LegalAddress}";
        }

        // TODO: неверный формат комментариев
        // TODO: ParseOrganization
        /// <summary>
        /// Перевод строки в экземпляр организации
        /// </summary>
        /// <param name="stringRepresentationForOrganization"></param>
        /// строка
        /// <returns></returns>
        /// экземпляр организации
        public Organization StringToOrganization(string stringRepresentationForOrganization)
        {
            var data = stringRepresentationForOrganization.Split(' ');
            
            var Id = int.Parse(data[0]);
            var name = data[1];
            var legalAddress = data[2];

            Organization organization = new Organization(Id, name, legalAddress);
            return organization;
        }

        // TODO: в DepartmentDataManager писал как можно упростить
        /// <summary>
        /// Добавление строкового представления в файл
        /// </summary>
        /// <param name="stringRepresentationForOrganization"></param>
        /// строка
        private void AppendOrganizationInFile(string stringRepresentationForOrganization)
        {
            using (Stream stream = File.Open(PathStorage.PathToOrganizations, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    sw.Write(stringRepresentationForOrganization);
                    sw.Close();
                }
                stream.Close();
            }
        }

        /// <summary>
        /// Выбор списка без 1 участника = удаление
        /// </summary>
        /// <param name="organization"></param>
        /// экземпляр организации
        /// <returns></returns>
        /// новый список
        private List<Organization> GetOrganizationsWithoutSelected(Organization organization)
        {
            return GetAllLines()
                .Select(l => StringToOrganization(l))
                .Where(l => l.Id != organization.Id)
                .ToList();
        }
    }
}
