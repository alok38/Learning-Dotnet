namespace Employee_Example
{
    public class MainClass
    {
        static string name;
        static decimal basic, da, hra;
        public static void Main(string[] args)
        {
            int empId;
            byte option;
            string choice;
            int counter = 0;
            Employee[] employees = new Employee[10];
            do
            {
                Console.WriteLine("Select Option:\n1.Joining a new employee\n2.Print Salaryslip of an Employee\n3.Print Salaryslips of all Employees\n4.Exit\nEnter a choice:");
                option = byte.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter Employee Name:");
                        name = Console.ReadLine();
                        Console.Write("Enter basic:");
                        basic = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Da:");
                        da = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Hra:");
                        hra = decimal.Parse(Console.ReadLine());
                        employees[counter++] = new Employee(name, basic, da, hra);
                        Console.WriteLine("Employee joined succesfully");
                        break;
                    case 2:
                        Console.WriteLine("Enter Employee Id:");
                        empId = int.Parse(Console.ReadLine());
                        for (int i = 0; i < counter; i++)
                        {
                            if (empId == employees[i].Id)
                            {
                                Console.WriteLine(employees[i].printSalarySlip());
                            }
                            else
                            {
                                Console.WriteLine("No such Employee exists");
                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < counter; i++)
                        {
                            Console.WriteLine(employees[i].printSalarySlip());
                        }
                        break;
                    case 4:
                        Console.WriteLine("thankyou");
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Continue?(y/n)");
                choice = Console.ReadLine();
            } while (choice == "Y" || choice == "y");
        }
    }
}