using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationInfo
{
    // TODO:  комментарии
    // TODO: не использовать в DataManagers
    public class IdInformation
    {
        public int? OrganizationId;

        public int? DepartmentId;

        public int? EmployeeId;

        public IdInformation() { }

        public IdInformation(int? orgId, int? depId, int? empId)
        {
            OrganizationId = orgId;
            DepartmentId = depId;
            EmployeeId = empId;
        }

        public IdInformation(int? orgId)
            :this (orgId, null, null) { }

        public IdInformation(int? orgId, int? depId)
            :this(orgId, depId, null) { }
    }
}
