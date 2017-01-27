using System.Collections.Generic;

namespace OrganizationInfo
{
    // TODO: комментарии
    interface IEmployeeDataManager : IDataManager<Employee>
    {
        // TODO: просто int Id
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        List<Employee> GetAllByDepartmentId(IdInformation Ids);

        // TODO: просто int
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        List<Employee> GetAllByOrganizationId(int? organizationId);

        // TODO: просто int
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        List<Employee> GetAllWithoutDepartment(int? organizationId);
    }
}
