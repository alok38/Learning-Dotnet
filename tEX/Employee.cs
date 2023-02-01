using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tEX
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }

        [Display(Name = "Department")]
        public virtual int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Departments { get; set; }

        [Display(Name = "Project")]
        public virtual int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public virtual Project Projects { get; set; }
    }
}
