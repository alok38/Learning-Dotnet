namespace Student_Example
{
    public class MainClass
    {
        static Student[] students = new Student[10];
        static int index;
        static byte option;
        static string name;
        static int counter;
        static decimal engMarks, scienceMarks, socialStudiesMarks;
        static void Input()
        {
            Console.Write("Enter Student's Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Student's English Marks: ");
            engMarks = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Student's Science Marks: ");
            scienceMarks = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Student's SocialStudies Marks: ");
            socialStudiesMarks = decimal.Parse(Console.ReadLine());
        }
        static bool studentSearch(int rollNumber)
        {
            for (int index = 0; index < counter; index++)
            {
                if (rollNumber == students[index].RollNumber)
                {
                    return true;
                }
            }
            return false;
        }
        static void printAllMarksheets()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(students[i].printMarksheet());
                Console.WriteLine("------------------------------");
            }
        }
        public static void Main(string[] args)
        {
            int tempRollNumber;
            string choice = "y";
            do
            {
                Console.Write("Select an option: \n1.Enroll a Student\n2.Print a Student's Marksheet\n3.Print all Student's Marksheets\n4.Exit\nEnter Your Choice: ");
                option = byte.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Input();
                        students[counter++] = new Student(name, engMarks, scienceMarks, socialStudiesMarks);
                        Console.WriteLine("Student Enrolled, RollNo is {0}", students[counter - 1].RollNumber);
                        break;
                    case 2:
                        Console.Write("Enter Student's Roll Number: ");
                        tempRollNumber = int.Parse(Console.ReadLine());
                        if (studentSearch(tempRollNumber))
                        {
                            Console.WriteLine(students[index].printMarksheet());
                        }
                        else
                        {
                            Console.WriteLine("Student does not exists");
                        }
                        break;
                    case 3:
                        printAllMarksheets();
                        break;
                    case 4:
                        Console.WriteLine("Thankyou!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }
                Console.WriteLine("Continue?(y/n): ");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "Y");
        }
    }
}