using System;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using LinqToDataSet;
using LinqToDataSet.DataSet1TableAdapters;

namespace LinqToDataSet
{
    class MainClass
    {

        static void UnTypedDataset()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = objConn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            objConn.ConnectionString = strConn;
            string Cmd = @"Select * From Employees";
            objCmd.Connection = objConn;
            objCmd.CommandText = Cmd;

            DataSet ds = new DataSet();
            da.SelectCommand = objCmd;
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            da.Fill(ds, "Employees");
            DataTable dt = ds.Tables["Employees"];

            //DataRow row = dt.NewRow();
            //row["ID"] = 120;
            //row["Name"] = "Anon";
            //row["Salary"] = 12000;
            //row["DID"] = 1;
            //dt.Rows.Add(row);
            //da.Update(dt);

            var Query = from emp in dt.AsEnumerable()
                        select new
                        {
                            ID = emp.Field<Int16>("ID"),
                            Name = emp.Field<string>("Name"),
                            Salary = emp.Field<decimal>("Salary"),
                            Department = emp.Field<Int16>("DID")
                        };
            Console.Write("ID\t");
            Console.Write("Name\t");
            Console.Write("\tSalary\t");
            Console.WriteLine("\tDepartment");
            Console.WriteLine("---------------------------------------------------");


            foreach (var e in Query)
            {
                Console.Write("{0}\t", e.ID);
                Console.Write("{0}\t", e.Name);
                Console.Write("{0}\t", e.Salary);
                Console.WriteLine("{0}\t", e.Department);

            }

        }
        static void TypedDataSet()
        {
            DataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter = new DataSet1TableAdapters.EmployeesTableAdapter();

            DataSet1 ds1 = new DataSet1();
            employeesTableAdapter.Fill(ds1.Employees);

            var query = from emp in ds1.Employees
                        select new
                        {
                            ID = emp.ID,
                            Name = emp.Name,
                            Salary = emp.Salary,
                            Department = emp.DID
                        };
            //DataSet1.EmployeesRow row = ds1.Employees.NewEmployeesRow();
            //row.Name = "Pkok";
            //row.Salary = 14000;
            //row.DID = 4;
            //ds1.Employees.Rows.Add(row);
            //employeesTableAdapter.Update(ds1.Employees);

            Console.Write("ID\t");
            Console.Write("Name\t");
            Console.Write("\tSalary\t");
            Console.WriteLine("\tDepartment");
            Console.WriteLine("---------------------------------------------------");


            foreach (var e in query)
            {
                Console.Write("{0}\t", e.ID);
                Console.Write("{0}\t", e.Name);
                Console.Write("{0}\t", e.Salary);
                Console.WriteLine("{0}\t", e.Department);

            }

        }


        static void TwoTableQuery()
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = objConn.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            objConn.ConnectionString = strConn;
            string Cmd = @"Select * From Employees";
            objCmd.Connection = objConn;
            objCmd.CommandText = Cmd;

            DataSet ds = new DataSet();
            da.SelectCommand = objCmd;
            da.Fill(ds, "Employees");
            DataTable dt = ds.Tables["Employees"];

            Cmd = @"Select * From Departments";
            objCmd.CommandText = Cmd;
            da.Fill(ds, "Departments");
            DataTable dt2 = ds.Tables["Departments"];

            var query =
                from Employee in dt.AsEnumerable()
                join Department in dt2.AsEnumerable()
                on Employee.Field<Int16>("DID") equals
                Department.Field<Int16>("DID")
                orderby Department.Field<Int16>("DID")
                select new
                {
                    EmployeeID = Employee.Field<Int16>("ID"),
                    EmployeeName = Employee.Field<string>("Name"),
                    EmployeeSalary = Employee.Field<decimal>("Salary"),
                    DepartmentName = Department.Field<string>("DeptName")
                };
            foreach (var data in query)
            {
                Console.WriteLine("EmployeeID={0}", data.EmployeeID);
                Console.WriteLine("EmployeeName={0}", data.EmployeeName);
                Console.WriteLine("EmployeeSalary={0}", data.EmployeeSalary);
                Console.WriteLine("DepartmentName={0}", data.DepartmentName);
                Console.WriteLine("--------------------------------------------------");
            }

        }
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


            //UnTypedDataset();
            //TypedDataSet();
            //TwoTableQuery();
            TwoTableTypedQuery();
        }


    }
}