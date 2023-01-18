using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class AnotherEmployeeListViewModel
    {
        public List<AnotherEmployeeViewModel> MyEmployees { get; set; }
        public string UserName { get; set; }
    }
}