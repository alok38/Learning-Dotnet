using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDataLayerStart.ViewModel
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public string SalaryColor { get; set; }
    }
}