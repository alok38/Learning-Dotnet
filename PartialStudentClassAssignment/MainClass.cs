using Exception_Library;
namespace PartialStudentClassAssignment
{

    public class MainClass
    {
        static int index;
        static List<Student> students = new List<Student>();
        static bool StudentCheck(int rollNumber)
        {
            for (index = 0; index < students.Count; index++)
            {
                if (rollNumber == students[index].rollNumber)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {
            byte choice;
            int counter = 0;
            string option = "y";
        Return:
            do
            {
                Console.Write("Select an option: \n1.create student\n2.Display a Student's MarkSheet\n3.Display Marksheet of all students\nYour Choice: ");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Your Marks: ");
                        int marks = int.Parse(Console.ReadLine());
                        try
                        {
                            students.Add(new Student(name, marks));

                        }
                        catch (MarksNegativeException m)
                        {
                            Console.WriteLine(m.Message);

                            goto Return;
                        }
                        catch (MarksOverException m)
                        {
                            Console.WriteLine(m.Message);

                            goto Return;
                        }
                        Console.WriteLine("Student Created,Your rollnumber is: " + students[counter++].rollNumber);
                        break;
                    case 2:
                        Console.WriteLine("Enter Your roll number: ");
                        int rollNumber = int.Parse(Console.ReadLine());
                        if (StudentCheck(rollNumber))
                        {
                            Console.WriteLine(students[index].PrintMarksheet());
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid rollNumber");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < students.Count; i++)
                        {
                            Console.WriteLine(students[i].PrintMarksheet());
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