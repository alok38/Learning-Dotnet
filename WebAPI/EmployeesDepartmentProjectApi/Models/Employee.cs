using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmployeesDepartmentProjectApi.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }
        
        [Display(Name = "Department")]
        public  int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Departments { get; set; }

        [Display(Name ="Project")]
        public int ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public  Project Projects { get; set; }
    }
}