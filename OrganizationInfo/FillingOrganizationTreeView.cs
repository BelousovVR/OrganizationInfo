using System.Collections.Generic;
using System.Windows.Forms;

namespace OrganizationInfo
{
    public static class FillingOrganizationTreeView
    {
        // TODO: комментарии
        /// <summary>
        /// 
        /// </summary>
        /// <param name="organizations"></param>
        /// <param name="treeView1"></param>
        public static void FillingOrgs(List<Organization> organizations, TreeView treeView1)
        {
            foreach (var org in organizations)
            {
                TreeNode orgNode = new TreeNode { Text = org.Name, Tag = new IdInformation(org.Id, null, null) };
                TreeNode departments = new TreeNode { Text = "Departments", Tag = new IdInformation(org.Id, -1, null) };
                TreeNode employees = new TreeNode { Text = "Employees", Tag = new IdInformation(org.Id, 0, null) };

                FillingDeps(departments, org);
                FillingEmps(employees, org.Employees);

                orgNode.Nodes.Add(employees);
                orgNode.Nodes.Add(departments);

                treeView1.Nodes.Add(orgNode);
            }
        }

        // TODO: комментарии
        /// <summary>
        /// 
        /// </summary>
        /// <param name="orgNode"></param>
        /// <param name="org"></param>
        private static void FillingDeps(TreeNode orgNode, Organization org)
        {
            foreach (var dep in org.Departments)
            {
                TreeNode depNode = new TreeNode { Text = dep.Name, Tag = new IdInformation(org.Id, dep.Id, null) };
                if (dep.Employees.Count != 0)
                {
                    TreeNode employees = new TreeNode { Text = "Employees", Tag = new IdInformation(org.Id, dep.Id, 0) };

                    FillingEmps(employees, dep.Employees);
                    depNode.Nodes.Add(employees);
                }

                orgNode.Nodes.Add(depNode);
            }
        }

        // TODO: комментарии
        /// <summary>
        /// 
        /// </summary>
        /// <param name="depNode"></param>
        /// <param name="emps"></param>
        private static void FillingEmps(TreeNode depNode, List<Employee> emps)
        {
            foreach (var emp in emps)
            {
                TreeNode empNode = new TreeNode { Text = emp.Name, Tag = new IdInformation(emp.OrganizationID, emp.DepartmentID, emp.Id) };
                depNode.Nodes.Add(empNode);
            }
        }
    }
}
