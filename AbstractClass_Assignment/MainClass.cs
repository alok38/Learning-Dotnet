namespace AbstractClass_Assignment
{
    public class MainClass
    {
        public static void Main(string[] args)
        {

            ScienceStudent s1 = new ScienceStudent("Alok", "11th");
            ScienceStudent s2 = new ScienceStudent("Sachin", "9th");

            HistoryStudent s3 = new HistoryStudent("Bhushan", "12th");
            HistoryStudent s4 = new HistoryStudent("Mukesh", "8th");

            s1.PhysicsMarks = 48;
            s1.ChemistryMarks = 90;
            s1.MathsMarks = 56;

            s2.PhysicsMarks = 91;
            s2.ChemistryMarks = 79;
            s2.MathsMarks = 60;

            s3.HistoryMarks = 87;
            s3.CivicsMarks = 87;



            s4.HistoryMarks = 49;
            s4.CivicsMarks = 94;

            Console.WriteLine(s1.getPercentage());
            Console.WriteLine(s2.getPercentage());
            Console.WriteLine(s3.getPercentage());
            Console.WriteLine(s4.getPercentage());

            Console.WriteLine(ScienceStudent.noOfStudents);



        }
    }
}