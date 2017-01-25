using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationInfo
{
    public class Department
    {
        //id организации
        public int? OrganizationID { get; set; }
        //id отдела
        public int? Id { get; set; }
        //Название отдела
        public string Name { get; set; }
        //Адрес отдела
        public string Address { get; set; }
        //Вместимость
        public int MaxNumberOfEmployees { get; set; }
        //Список сотрудников
        public List<Employee> Employees { get; set; }

        public Department() { }

        public Department(int? orgID,int? depID, string name, string address, int maxN)
            : this(orgID, depID, name, address, maxN, new List<Employee>()) { }

        public Department(int? orgId, string name, string address, int maxN)
            :this(orgId, -3, name, address, maxN, new List<Employee>()) { }

        public Department(int? orgID, int? depID, string name, string address, int maxN, List<Employee> emps)
        {
            OrganizationID = orgID;
            Id = depID;
            Name = name;
            Address = address;
            MaxNumberOfEmployees = maxN;
            Employees = emps;
        }
    }
}
