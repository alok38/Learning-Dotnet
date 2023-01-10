namespace Employee_Polymorpism
{
    public class MainClass
    {
        static byte counter;
        static string name;
        static decimal basic, da, hra, allowance;
        static Employee[] employees = new Employee[10];
        static void Input()
        {
            Console.Write("Enter employee name:");
            name = Console.ReadLine();
            Console.Write("Enter employee basic salary:");
            basic = decimal.Parse(Console.ReadLine());
            Console.Write("Enter employee da:");
            da = decimal.Parse(Console.ReadLine());
            Console.Write("Enter employee hra:");
            hra = decimal.Parse(Console.ReadLine());
        }
        static void PrintAll()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(employees[i].printSalarySlip());
                Console.WriteLine("---------------------------------------------------------------------");
            }
        }
        public static void Main(string[] args)
        {
            byte choice, innerChoice;
            string option;
            do
            {
                Console.Write("Select and option:\n1.Join an Employee\n2.print details of all employees\nEnter your choice:");
                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Select Employee role: \n1.Hr\n2.Admin\n3.Software\nEnter Your Choice:");
                        innerChoice = byte.Parse(Console.ReadLine());
                        switch (innerChoice)
                        {
                            case 1:
                                Input();
                                Console.Write("Enter Hr allowance:");
                                allowance = decimal.Parse(Console.ReadLine());
                                employees[counter++] = new Hr(name, basic, da, hra, allowance);
                                break;
                            case 2:
                                Input();
                                Console.Write("Enter Admin allowance:");
                                allowance = decimal.Parse(Console.ReadLine());
                                employees[counter++] = new Admin(name, basic, da, hra, allowance);
                                break;
                            case 3:
                                Input();
                                Console.Write("Enter Project allowance:");
                                allowance = decimal.Parse(Console.ReadLine());
                                employees[counter++] = new Software(name, basic, da, hra, allowance);
                                break;
                        }
                        Console.WriteLine("Employee joined succesfully empId: {0}", employees[counter - 1].empId);
                        break;
                    case 2:
                        PrintAll();
                        break;

                }
                Console.Write("Continue?(Y/N): ");
                option = Console.ReadLine();
            } while (option == "Y" || option == "y");
        }
    }
}