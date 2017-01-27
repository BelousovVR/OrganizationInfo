using System.Collections.Generic;

namespace OrganizationInfo
{
    // TODO: комментарии
    interface IDepartmentDataManager : IDataManager<Department>
    {
        // TODO: просто int
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        List<Department> GetAllByOrganizationId(int? organizationId);

        // TODO: комментарии
        void DeleteEmployees(Department dep);
    }
}
