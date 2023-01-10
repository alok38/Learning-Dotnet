using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Service_Project
{
    public class MainClass
    {
        static byte choice,selectChoice,updateChoice;
        static string Name;
        static char option;
        static decimal Salary;
        static DateTime dob,doj;
        static int PID, DID, ID;
        static string Gender;

        static LTIMindtreedbDataContext mdc = new LTIMindtreedbDataContext();
        static Employee SelectEmployeesDetailsWithEmpId(int id)
        {
            List<Employee> list = (from emp in mdc.Employees
                                   where emp.EmpId == id
                                   select emp).ToList<Employee>();
            return list[0];
        }
        static List<Employee> SelectAllEmployees()
        {
            return (from emp in mdc.Employees
                    select emp).ToList<Employee>();
        }

        static List<Employee> SelectEmployeeWithDepartmentId(int id)
        {

            return (from emp in mdc.Employees
                    where emp.DeptId == id
                    select emp).ToList<Employee>();

        }
        static List<Employee> SelectEmployeeByGender(string gender)
        {

            return (from emp in mdc.Employees
                    where emp.EmpGender.Equals(gender)
                    select emp).ToList<Employee>();

        }
        static void UpdateEmployeeByName(int id,string Name) 
        {

            List<Employee> list = (from emp in mdc.Employees
                                   where emp.EmpId == id
                                   select emp).ToList<Employee>();

            list[0].EmpName = Name;
            mdc.SubmitChanges();
            Console.WriteLine("Employee Updated");



        }
        static void UpdateEmployeeByProject(int id,int pid)
        {

            List<Employee> list = (from emp in mdc.Employees
                                   where emp.EmpId == id
                                   select emp).ToList<Employee>();

            list[0].ProjectId = pid;
            mdc.SubmitChanges();
            Console.WriteLine("Employee Updated");



        }
        static void UpdateEmployeeBySalary(int id,decimal salary)
        {

            List<Employee> list = (from emp in mdc.Employees
                                   where emp.EmpId == id
                                   select emp).ToList<Employee>();

            
            list[0].EmpSalary = salary;
            mdc.SubmitChanges();
            Console.WriteLine("Employee Updated");



        }
        static void InsertEmployee(string Name,decimal salary,string gender, DateTime dob, DateTime doj,int pid, int did)
        {

            
            Employee emp = new Employee();

            emp.EmpName = Name;
            emp.EmpGender = gender;
            emp.EmpSalary = salary;
            emp.EmpDoj = doj;
            emp.EmpDob = dob;
            emp.ProjectId = pid;
            emp.DeptId = did;

            mdc.Employees.InsertOnSubmit(emp);
            mdc.SubmitChanges();




        }


        static void SelectMostAndLeastEmployeeByExp()
        {

            List<Employee> Empexperience = (from emp in mdc.Employees
                                            orderby emp.EmpDoj
                                            select emp).ToList<Employee>();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Most Experienced Employee details");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("ID ={0}\t", Empexperience[0].EmpId);
            Console.WriteLine("\nName ={0}\t", Empexperience[0].EmpName);
            Console.WriteLine("\nSalary ={0}\t", Empexperience[0].EmpSalary);
            Console.WriteLine("\nDate of birth ={0}", Empexperience[0].EmpDob);
            Console.WriteLine("\nDate of Joining ={0}", Empexperience[0].EmpDoj);
            Console.WriteLine("\nGender ={0}", Empexperience[0].EmpGender);
            Console.WriteLine("\nProjectId ={0}", Empexperience[0].ProjectId);
            Console.WriteLine("\nDeptId ={0}", Empexperience[0].DeptId);
            Console.WriteLine();

            Empexperience = (from emp in mdc.Employees
                             orderby emp.EmpDoj descending
                             select emp).ToList<Employee>();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Least Experienced Employee details ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("ID ={0}\t", Empexperience[0].EmpId);
            Console.WriteLine("\nName ={0}\t", Empexperience[0].EmpName);
            Console.WriteLine("\nSalary ={0}\t", Empexperience[0].EmpSalary);
            Console.WriteLine("\nDate of birth ={0}", Empexperience[0].EmpDob);
            Console.WriteLine("\nDate of Joining ={0}", Empexperience[0].EmpDoj);
            Console.WriteLine("\nGender ={0}", Empexperience[0].EmpGender);
            Console.WriteLine("\nProjectId ={0}", Empexperience[0].ProjectId);
            Console.WriteLine("\nDeptId ={0}", Empexperience[0].DeptId);

        }

        static void DeleteEmployee(int id)
        {
            List<Employee> list = (from emp in mdc.Employees
                                   where emp.EmpId == id
                                   select emp).ToList<Employee>();

            mdc.Employees.DeleteOnSubmit(list[0]);
            mdc.SubmitChanges();

            Console.WriteLine("Employee with empId {0} Deleted Successfully", list[0].EmpId);
        }
        static List<Employee> SelectEmployeeByIncreasingSalary()
        {

            return (from emp in mdc.Employees
                    orderby emp.EmpSalary
                    select emp).ToList<Employee>();

        }

        static void PrintingDepartmentMinMaxAndTotalSalary(int did)
        {
            decimal sum = 0;
            

            List<decimal> sal = (from emp in mdc.Employees
                                 where emp.DeptId == did
                                 orderby emp.EmpSalary
                                 select emp.EmpSalary).ToList<decimal>();
            Console.WriteLine("Minimum Salary is {0}", sal[0]);

            sal = (from emp in mdc.Employees
                   where emp.DeptId == did
                   orderby emp.EmpSalary descending
                   select emp.EmpSalary).ToList<decimal>();
            Console.WriteLine("Maximum Salary is {0}", sal[0]);
            foreach (decimal d in sal)
            {
                sum += d;

            }
            Console.WriteLine("Total Salary is {0}", sum);

        }


        static List<Employee> SelectEmployeeByDOB()
        {

            return (from emp in mdc.Employees
                    orderby emp.EmpDob descending
                    select emp).ToList<Employee>();

        }
        static void SelectEmployeeNameProjectNameAndDeptName()
        {

            var query = from emp in mdc.Employees
                        join dept in mdc.Departments
                        on emp.DeptId equals dept.DeptId
                        join pro in mdc.Projects on
                        emp.ProjectId equals pro.ProjectId
                        select new
                        {
                            EmpName = emp.EmpName,
                            DeptName = dept.DeptName,
                            ProjectName = pro.ProjectName

                        };

            Console.Write("Employee Name\t");
            Console.Write("\tDepartment Name");
            Console.WriteLine("\t\tProject Name");
            Console.WriteLine("---------------------------------------------------------------");


            foreach (var e in query)
            {
                Console.Write("{0}\t", e.EmpName);
                Console.Write("\t{0}\t", e.DeptName);
                Console.WriteLine("\t{0}", e.ProjectName);



            }

        }

        static List<Employee> SelectEmployeeWorkingInSameProjectId(int id)
        {

            return (from emp in mdc.Employees
                    where emp.ProjectId == id
                    select emp).ToList<Employee>();

        }
        static void PrintEmployeeDOBWise()
        {
            foreach (var e in SelectEmployeeByDOB())
            {
                Console.WriteLine("ID ={0}\t", e.EmpId);
                Console.WriteLine("\nName ={0}\t", e.EmpName);
                Console.WriteLine("\nSalary ={0}\t", e.EmpSalary);
                Console.WriteLine("\nDate of birth ={0}", e.EmpDob);
                Console.WriteLine("\nDate of Joining ={0}", e.EmpDoj);
                Console.WriteLine("\nGender ={0}", e.EmpGender);
                Console.WriteLine("\nProjectId ={0}", e.ProjectId);
                Console.WriteLine("\nDeptId ={0}", e.DeptId);
                Console.WriteLine("-------------------------------");

            }
        }
        static void PrintEmployeeSalaryWise()
        {
            foreach (var e in SelectEmployeeByIncreasingSalary())
            {
                Console.WriteLine("ID ={0}\t", e.EmpId);
                Console.WriteLine("\nName ={0}\t", e.EmpName);
                Console.WriteLine("\nSalary ={0}\t", e.EmpSalary);
                Console.WriteLine("\nDate of birth ={0}", e.EmpDob);
                Console.WriteLine("\nDate of Joining ={0}", e.EmpDoj);
                Console.WriteLine("\nGender ={0}", e.EmpGender);
                Console.WriteLine("\nProjectId ={0}", e.ProjectId);
                Console.WriteLine("\nDeptId ={0}", e.DeptId);
                Console.WriteLine("-------------------------------");

            }
        }
        static void PrintEmployeeAccToGender(string gen)

        {

            foreach (var e in SelectEmployeeByGender(gen))
            {
                Console.WriteLine("ID ={0}\t", e.EmpId);
                Console.WriteLine("\nName ={0}\t", e.EmpName);
                Console.WriteLine("\nSalary ={0}\t", e.EmpSalary);
                Console.WriteLine("\nDate of birth ={0}", e.EmpDob);
                Console.WriteLine("\nDate of Joining ={0}", e.EmpDoj);
                Console.WriteLine("\nGender ={0}", e.EmpGender);
                Console.WriteLine("\nProjectId ={0}", e.ProjectId);
                Console.WriteLine("\nDeptId ={0}", e.DeptId);
                Console.WriteLine("-------------------------------");

            }
        }

        static void PrintEmployeeDetails(int id)
        {
           
            var e = SelectEmployeesDetailsWithEmpId(id);

            Console.WriteLine("ID ={0}\t", e.EmpId);
            Console.WriteLine("\nName ={0}\t", e.EmpName);
            Console.WriteLine("\nSalary ={0}\t", e.EmpSalary);
            Console.WriteLine("\nDate of birth ={0}", e.EmpDob);
            Console.WriteLine("\nDate of Joining ={0}", e.EmpDoj);
            Console.WriteLine("\nGender ={0}", e.EmpGender);
            Console.WriteLine("\nProjectId ={0}", e.ProjectId);
            Console.WriteLine("\nDeptId ={0}", e.DeptId);
            Console.WriteLine("-------------------------------");


        }
        static void PrintQuery()
        {
            foreach (var e in SelectAllEmployees())
            {
                Console.WriteLine("ID ={0}\t", e.EmpId);
                Console.WriteLine("\nName ={0}\t", e.EmpName);
                Console.WriteLine("\nSalary ={0}\t", e.EmpSalary);
                Console.WriteLine("\nDate of birth ={0}", e.EmpDob);
                Console.WriteLine("\nDate of Joining ={0}", e.EmpDoj);
                Console.WriteLine("\nGender ={0}", e.EmpGender);
                Console.WriteLine("\nProjectId ={0}", e.ProjectId);
                Console.WriteLine("\nDeptId ={0}", e.DeptId);
                Console.WriteLine("-------------------------------");

            }
        }
        static void PrintDeptQuery(int did)
        {
           
            foreach (var e in SelectEmployeeWithDepartmentId(did))
            {
                Console.WriteLine("ID ={0}\t", e.EmpId);
                Console.WriteLine("\nName ={0}\t", e.EmpName);
                Console.WriteLine("\nSalary ={0}\t", e.EmpSalary);
                Console.WriteLine("\nDate of birth ={0}", e.EmpDob);
                Console.WriteLine("\nDate of Joining ={0}", e.EmpDoj);
                Console.WriteLine("\nGender ={0}", e.EmpGender);
                Console.WriteLine("\nProjectId ={0}", e.ProjectId);
                Console.WriteLine("\nDeptId ={0}", e.DeptId);
                Console.WriteLine("--------------------------------------");
            }
        }
        static void PrintProjectQuery(int pid)
        {
            
            foreach (var e in SelectEmployeeWorkingInSameProjectId(pid))
            {
                Console.WriteLine("ID ={0}\t", e.EmpId);
                Console.WriteLine("\nName ={0}\t", e.EmpName);
                Console.WriteLine("\nSalary ={0}\t", e.EmpSalary);
                Console.WriteLine("\nDate of birth ={0}", e.EmpDob);
                Console.WriteLine("\nDate of Joining ={0}", e.EmpDoj);
                Console.WriteLine("\nGender ={0}", e.EmpGender);
                Console.WriteLine("\nProjectId ={0}", e.ProjectId);
                Console.WriteLine("\nDeptId ={0}", e.DeptId);
                Console.WriteLine("--------------------------------------");
            }
        }



        static void Menu()
        {
            do
            {
                Console.Write("Select an option: \n1.Select Based on Requirements \n2.Insert an Employee \n3.Update Employee Details \n4.Delete An Employee \n5.Exit \nYour Choice: ");
                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select an Option \n1.Select All Employees \n2.Select Employees Based on Gender \n3.Select Employees Based on Department \n4.Select Employees Based on Projects \n5.Order Employees Based on their Age \n6.Order Employees Based on their Salary \n7.Find Min,Max and Total Salary From a department \n8.Find The Most And least Experienced Employee \n9.Select Employee by ID \n10.Print Employee Name,Department Name,Project Name");
                        selectChoice = byte.Parse(Console.ReadLine());
                        switch (selectChoice)
                        {
                            case 1:
                                PrintQuery();
                                break;
                            case 2:
                                Console.Write("Enter Gender By Which YOu Want To Filter(M/F): ");
                                Gender = Console.ReadLine();
                                PrintEmployeeAccToGender(Gender);
                                break;

                            case 3:
                                Console.Write("Select Department By ID \n 1.Hr \n2.Admin \n3.Software \n4.Sales");
                                DID = int.Parse(Console.ReadLine());
                                PrintDeptQuery(DID);
                                break;

                            case 4:
                                Console.Write("Select Project By ID \n 1.Addidas \n2.Deloitte \n3.Amazon \n4.Dassault \n5.Starbuck \n6.Byjus");
                                PID = int.Parse(Console.ReadLine());
                                PrintProjectQuery(PID);
                                break;

                            case 5:
                                PrintEmployeeDOBWise();
                                break;

                            case 6:
                                PrintEmployeeSalaryWise();
                                break;

                            case 7:
                                Console.Write("Select Department By ID \n 1.Hr \n2.Admin \n3.Software \n4.Sales");
                                DID = int.Parse(Console.ReadLine());
                                PrintingDepartmentMinMaxAndTotalSalary(DID);
                                break;

                            case 8:
                                SelectMostAndLeastEmployeeByExp();
                                break;

                            case 9:
                                Console.WriteLine("Enter Employee ID: ");
                                ID = int.Parse(Console.ReadLine());
                                PrintEmployeeDetails(ID);
                                break;

                            case 10:
                                SelectEmployeeNameProjectNameAndDeptName();
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("Enter Employee Name: ");
                        Name = Console.ReadLine();
                        Console.Write("Enter Employee Salary: ");
                        Salary = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter Employee Gender (M/F): ");
                        Gender = Console.ReadLine();
                        Console.Write("Enter Employee DOB: ");
                        dob = Convert.ToDateTime(Console.ReadLine());
                        doj = DateTime.Now;
                        Console.Write("Enter Project ID: ");
                        PID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Department ID: ");
                        DID = Convert.ToInt32(Console.ReadLine());
                        InsertEmployee(Name, Salary, Gender, dob, doj, PID, DID);
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee ID");
                        ID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Which Field To Update: \n1.Name \n2.Salary \n3.Project \nEnter: ");
                        updateChoice = byte.Parse(Console.ReadLine());
                        switch (updateChoice)
                        {
                            case 1:
                                Console.WriteLine("Enter Name: ");
                                Name = Console.ReadLine();
                                UpdateEmployeeByName(ID,Name);
                                break;

                            case 2:
                                Console.WriteLine("Enter Salary: ");
                                Salary = decimal.Parse(Console.ReadLine());
                                UpdateEmployeeBySalary(ID, Salary);
                                break;
                               

                            case 3:
                                Console.WriteLine("Enter Project ID: ");
                                PID = int.Parse(Console.ReadLine());
                                UpdateEmployeeByProject(ID, PID);
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Employee ID To Delete");
                        ID = Convert.ToInt32(Console.ReadLine());
                        DeleteEmployee(ID);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }
                Console.WriteLine("Continue?(Y/N): ");
                option = char.Parse(Console.ReadLine());
            } while (option == 'Y' || option == 'y');
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
