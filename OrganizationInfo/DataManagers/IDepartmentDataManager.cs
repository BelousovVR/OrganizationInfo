using System.Collections.Generic;

namespace OrganizationInfo
{
    interface IDepartmentDataManager : IDataManager<Department>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        List<Department> GetAllByOrganizationId(int? organizationId);

        void DeleteEmployees(Department dep);
    }
}
