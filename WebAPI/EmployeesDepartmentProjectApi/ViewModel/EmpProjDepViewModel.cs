using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeesDepartmentProjectApi.ViewModel
{
    public class EmpProjDepViewModel
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        public string DeptName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectClient { get; set; }
    }
}