using EmployeesDepartmentProjectApi.DataAccessLayer;
using EmployeesDepartmentProjectApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeesDepartmentProjectApi.ViewModel;

namespace EmployeesDepartmentProjectApi.Repository
{
  
        public class EmployeeRepository 
        {
            public List<Employee> employees = new List<Employee>();
            public MyDAL empl;
            public EmployeeRepository()
            {
                empl = new MyDAL();
            }
            public Employee Add(Employee item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
               
                empl.Employees.Add(item);
                empl.SaveChanges();
                return item;
            }
            public Employee Get(int id)
            {
                Employee emp  = empl.Employees.FirstOrDefault(x => x.Id == id);
                return emp;
            }
            public IEnumerable<Employee> GetAll()
            {
                return empl.Employees;
            }
            public void Remove(int id)
            {
                empl.Employees.Remove(empl.Employees.Find(id));
                empl.SaveChanges();

            }
            public bool Update(int id, Employee item)
            {
                if (item == null)
                {
                    throw new ArgumentNullException();
                }

                Employee found = empl.Employees.Find(id);

                found.Name = item.Name;
                found.Salary = item.Salary;
               
                empl.SaveChanges();
                return true;
            }


        public IEnumerable<Employee> GetAllEmployeesByDepartment(int deptid)
        {
            List<Employee> emplo = (from emp in empl.Employees
                    where emp.DepartmentId == deptid
                    select emp).ToList<Employee>();
            return emplo;
        }

        public List<Employee> SelectEmployeeByGender(string gender)
        {

            return (from emp in empl.Employees
                    where emp.Gender.Equals(gender)
                    select emp).ToList<Employee>();

        }

        public IEnumerable<Employee> GetAllEmployeesByProject(int id)
        {
            List<Employee> emplo = (from emp in empl.Employees
                                    where emp.ProjectId == id
                                    select emp).ToList<Employee>();
            return emplo;
        }

        public IEnumerable<EmpProjDepViewModel> GetAllTables()
        {
            var query = from emp in empl.Employees
                        join dept in empl.Departments
                        on emp.DepartmentId equals dept.DeptId
                        join pro in empl.Projects on
                        emp.ProjectId equals pro.ProjectId
                        select new
                        {
                            Name = emp.Name,
                            Salary = emp.Salary,
                            Gender = emp.Gender,
                            DeptName = dept.DeptName,
                            ProjectName = pro.ProjectName,
                            ProjectClient = pro.ProjectClient

                        };
            List<EmpProjDepViewModel> list = new List<EmpProjDepViewModel>();
            
            foreach(var e in query)
            {
                EmpProjDepViewModel epdvm = new EmpProjDepViewModel();
                epdvm.Name = e.Name;
                epdvm.Salary = e.Salary;
                epdvm.Gender = e.Gender;
                epdvm.ProjectName = e.ProjectName;
                epdvm.ProjectClient = e.ProjectClient;
                epdvm.DeptName = e.DeptName;
                list.Add(epdvm);
            }
            return list;
        }

        }
}
