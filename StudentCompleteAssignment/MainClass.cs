using Exception_Library;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace PartialStudentClassAssignment
{

    public class MainClass
    {
        static int index;
        static List<Student> students = new List<Student>();
       public  static bool StudentCheck(int rollNumber)
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
        static void BinarySerialization(List<Student> students)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\StudentsBinary.txt", FileMode.OpenOrCreate,FileAccess.Write);
            binFormatter.Serialize(fs, students);
            fs.Close();
        }
        static void BinaryDeSerialization()
        {
            List<Student> students;
            try
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\StudentsBinary.txt", FileMode.Open,FileAccess.Read);
               students = (List<Student>)binFormatter.Deserialize(fs);
                foreach(Student s in students)
                {
                    Console.WriteLine(s.PrintMarksheet());
                }
                fs.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void XmlSeriealize(List<Student> s)
        {
            
            XmlSerializer xs = new XmlSerializer(typeof(List<Student>));
           // FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\StudentsXml.xml", FileMode.Create, FileAccess.Write);
           using(var Writer = new StreamWriter("C:\\Users\\labuser\\Documents\\StudentsXml.txt")) {

                xs.Serialize(Writer, s);
                //fs.Close();
                Console.WriteLine("File Created");
            }
            //xs.Serialize(fs, s);
            //fs.Close();
            //Console.WriteLine("File Created"); 

        }
        static void XmlDeSerialize()
        {
            List<Student> s;

            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Student));
                FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\StudentsXml.txt", FileMode.Open, FileAccess.Read);
                s = (List<Student>)xs.Deserialize(fs);
                fs.Close();
                foreach (Student stu in s)
                {
                    Console.WriteLine(stu.PrintMarksheet());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main(string[] args)
        {
            byte choice;
            int counter = 0;
            string option = "y";
        Return:
            do
            {
                Console.Write("Select an option: \n1.create student\n2.Display a Student's MarkSheet\n3.Display Marksheet of all students\n4.BinarySerialization\n5.BinaryDeSerialization\n6.XmlSerialization\n7.XmlDeSerialization\nYour Choice: ");
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
                    case 4:
                        {
                            BinarySerialization(students);

                            Console.WriteLine("Serialization of data has been done");
                        }
                        break;
                    case 5:
                        {
                            BinaryDeSerialization();
                        }
                        break;
                    case 6:
                        {
                            XmlSeriealize(students);
                            Console.WriteLine("XmlSerialization Done");
                        }
                        break;
                    case 7:
                        {
                            XmlDeSerialize();
                        }
                        break;
                        
                }
                Console.WriteLine("continue?(y,n): ");
                option = Console.ReadLine();
            } while (option == "Y" || option == "y");
        }
    }
}