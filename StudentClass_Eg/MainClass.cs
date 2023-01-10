using System;


namespace StudentClass_Eg
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            byte choice;
           
            Student[] students = new Student[10];
            int counter=0;
            string option = "y";
            do
            {
                Console.Write("Select an option: \n1.create student\n2.Display all data\nYour Choice: ");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your Class: ");
                        int cl = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Sem: ");
                        int sem = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your branch: ");
                        string branch = Console.ReadLine();
                        students[counter++] = new Student(name, cl, sem, branch);
                        int[] intArray = new int[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("Enter Marks{0}", i + 1);
                            intArray[i] = int.Parse(Console.ReadLine());
                        }

                        students[counter - 1].MarksSetter(intArray);
                        Console.WriteLine("Your rollnumber is: " + students[counter - 1].RollNo);
                        Console.WriteLine(students[counter - 1].DisplayResult());
                        break;
                    case 2:
                        for (int i = 0; i < counter; i++)
                        {
                            Console.WriteLine(students[i].DisplayData());
                            Console.WriteLine("------------------------------------");

                        }
                        break;
                }
                Console.WriteLine("continue?(y,n): ");
                option = Console.ReadLine();
            } while (option == "Y" || option == "y");
        }
    }
}
