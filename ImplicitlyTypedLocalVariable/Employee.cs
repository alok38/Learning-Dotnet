using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVariable
{
    public class Employee
    {
        private int _empId;
        public int EmpId
        {
            get
            {
                return _empId;
            }
            set
            {
                _empId = value;
            }
        }
    }
}
