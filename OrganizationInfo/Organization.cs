using System.Collections.Generic;

namespace OrganizationInfo
{
    // TODO: нормальные комментарии
    public class Organization
    {

        // TODO: в данном случае Id должны быть просто int

        //id организации
        public int? Id { get; set; }
        //Название организации
        public string Name { get; set; }
        //Юридический адрес
        public string LegalAddress { get; set; }
        //Количество сотрудников компании
        public int QuantityOfEmployees { get; set; }
        //Список сотрудников, работающих без отдела(ген. директор и т.д.)
        public List<Employee> Employees { get; set; }
        //Список отделов
        public List<Department> Departments { get; set; }

        public Organization() { }

        public Organization(string name, string legalAddress)
            :this (0, name, legalAddress, new List<Department>(), new List<Employee>()) { }

        public Organization(int? orgID, string name, string legalAddress) 
            : this(orgID, name, legalAddress, new List<Department>(), new List<Employee>()) { }

        public Organization(int? orgID, string name, string legalAddress, List<Department> deps, List<Employee> emps)
        {
            Id = orgID;
            Name = name;
            LegalAddress = legalAddress;
            QuantityOfEmployees = 0; // TODO: неверно, т.к. я могу передать в конструктор список сотрудников, а их количество будет равно 0
            Departments = deps;
            Employees = emps;
        }
    }
}
