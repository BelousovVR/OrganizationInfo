using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationInfo
{
    public static class PathStorage
    {
        public static string PathToEmployees = Directory.GetCurrentDirectory() + "\\Organizations\\employees.txt";

        public static string PathToDepartments = Directory.GetCurrentDirectory() + "\\Organizations\\departments.txt";

        public static string PathToOrganizations = Directory.GetCurrentDirectory() + "\\Organizations\\organizations.txt";
    }
}
