namespace OrganizationInfo
{
    public class Employee
    {
        // TODO: в данном случае OrganizationID / Id должны быть просто int, т.к. работника без организации не существует
        // а вот  DepartmentID может быть int? т.к. работник может не иметь подразделения
        // TODO: нормальные комментарии ///

        //id организации
        public int? OrganizationID { get; set; }

        //id отдела
        public int? DepartmentID { get; set; }

        //id
        public int? Id { get; set; }

        //Имя
        public string Name { get; set; }

        //ИНН
        public string IndividualTaxNumber { get; set; }

        //Должность
        public string Post { get; set; }

        //Заработная плата
        public int Salary { get; set; }

        public Employee() { }

        public Employee(int? orgID, int? depID, string name, string itn, string post, int salary)
        {
            OrganizationID = orgID;
            DepartmentID = depID;
            Name = name;
            IndividualTaxNumber = itn;
            Post = post;
            Salary = salary;
        }

        public Employee(int? orgID, int? depID, int? id, string name, string itn, string post, int salary)
        {
            OrganizationID = orgID;
            DepartmentID = depID;
            Id = id;
            Name = name;
            IndividualTaxNumber = itn;
            Post = post;
            Salary = salary;
        }
    }
}
