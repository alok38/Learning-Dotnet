using EmployeesDepartmentProjectApi.Models;
using EmployeesDepartmentProjectApi.Repository;
using EmployeesDepartmentProjectApi.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeesDepartmentProjectApi.Controllers
{
    public class EmployeeController : ApiController
    {

        static readonly EmployeeRepository repository = new EmployeeRepository();

        public IEnumerable<Employee> GetAllEmployees()
        {
            return repository.GetAll();
        }
        public Employee GetEmployee(int id)
        {
            return repository.Get(id);

        }

        [HttpGet]
        public IEnumerable<Employee> EmployeesByDepartment(int id)
        {
            return repository.GetAllEmployeesByDepartment(id);
        }


        [HttpGet]
        public IEnumerable<Employee> EmployeesByGender(string gender)
        {
            return repository.SelectEmployeeByGender(gender);
        }


        [HttpGet]
        public IEnumerable<Employee> EmployeesByProject(int id)
        {
            return repository.GetAllEmployeesByProject(id);
        }

        [HttpGet]
        public IEnumerable<EmpProjDepViewModel> AllDetails()
        {
            return repository.GetAllTables();
        }

        public void PostEmployee(Employee item)
        {
            item = repository.Add(item);
        }
        public void PutEmployee(int id, Employee employee)
        {

            if (!repository.Update(id, employee))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
        public void DeleteEmployee(int id)
        {
            Employee item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repository.Remove(id);
        }


    }
}