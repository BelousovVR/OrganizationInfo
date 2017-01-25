using System.Collections.Generic;

namespace OrganizationInfo
{
    interface IEmployeeDataManager : IDataManager<Employee>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        List<Employee> GetAllByDepartmentId(IdInformation Ids);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        List<Employee> GetAllByOrganizationId(int? organizationId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        List<Employee> GetAllWithoutDepartment(int? organizationId);
    }
}
