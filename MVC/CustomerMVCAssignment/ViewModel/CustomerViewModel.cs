using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerMVCAssignment.ViewModel
{
    public class CustomerViewModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string AgeColor { get; set; }
    }
}