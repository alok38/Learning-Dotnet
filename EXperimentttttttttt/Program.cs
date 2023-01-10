using System;
using System.Linq;
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace EXperimentttttttttt
{
    class MainClass
    {

        SqlConnection objConn = new SqlConnection();

        static void TwoTableTypedQuery()
        {
            DataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter = new DataSet1TableAdapters.EmployeesTableAdapter();
            DataSet1TableAdapters.DepartmentsTableAdapter departmentsTableAdapter = new DataSet1TableAdapters.DepartmentsTableAdapter();
            DataSet1 ds1 = new DataSet1();
           
            employeesTableAdapter.Fill(ds1.Employees);
            departmentsTableAdapter.Fill(ds1.Departments);
            var query = from emp in ds1.Employees
                        join dept in ds1.Departments
                        on emp.DID equals dept.DID
                        orderby emp.DID
                        select new
                        {

                            Name = emp.Name,
                            Department = dept.DeptName
                        };

            Console.Write("Name\t");
            Console.WriteLine("\tDepartment");
            Console.WriteLine("---------------------------------------------------");


            foreach (var e in query)
            {
                Console.Write("{0}\t", e.Name);
                Console.WriteLine("{0}\t", e.Department);

            }
        }


        static void Main(string[] args)
        {
            TwoTableTypedQuery();
        }



    }
}