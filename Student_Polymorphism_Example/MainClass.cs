namespace Student_Polymorphism_Example { 
public class MainClass
{
    static Student[] students = new Student[10];
    static int index;
    static byte option, studentTypeOption;
    static string name;
    static int counter;
    static decimal engMarks, generalStudiesMarks, environmentStudiesMarks, scienceMarks, commerceMarks, socialStudiesMarks;
    static void Input()
    {
        Console.Write("Enter Student's Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Student's English Marks: ");
        engMarks = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Student's generalStudies Marks: ");
        generalStudiesMarks = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Student's environmentStudies Marks: ");
        environmentStudiesMarks = decimal.Parse(Console.ReadLine());
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
    static void StudentTypeInput()
    {
        Console.Write("Which Stream do you want to choose?\n1.Science\n2.Commerce\n3.Arts\nEnter Your Choice: ");
        studentTypeOption = byte.Parse(Console.ReadLine());
    }
    static void rollNoPrint()
    {
        Console.WriteLine("Student Enrolled, RollNo is {0}", students[counter - 1].RollNumber);
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
                    StudentTypeInput();
                    switch (studentTypeOption)
                    {
                        case 1:
                            Input();
                            Console.Write("Enter Student's Science Marks: ");
                            scienceMarks = decimal.Parse(Console.ReadLine());
                            students[counter++] = new ScienceStudent(name, engMarks, generalStudiesMarks, environmentStudiesMarks, scienceMarks);
                            rollNoPrint();
                            break;
                        case 2:
                            Input();
                            Console.Write("Enter Student's commerce Marks: ");
                            commerceMarks = decimal.Parse(Console.ReadLine());
                            students[counter++] = new CommerceStudent(name, engMarks, generalStudiesMarks, environmentStudiesMarks, commerceMarks);
                            rollNoPrint();
                            break;
                        case 3:
                            Input();
                            Console.Write("Enter Student's SocialStudies Marks: ");
                            socialStudiesMarks = decimal.Parse(Console.ReadLine());
                            students[counter++] = new ArtsStudent(name, engMarks, generalStudiesMarks, environmentStudiesMarks, socialStudiesMarks);
                            rollNoPrint();
                            break;
                    }
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
