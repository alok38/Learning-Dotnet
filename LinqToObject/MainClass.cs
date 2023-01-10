using System;
using System.Collections;
using System.Linq;

struct Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public int[] Scores;
}
class MainClass
{
    static void Main()
    {
        ArrayList StudentList = new ArrayList()
        {
            new Student
            {
                Name = "Alok",
                Age=23,
                Scores = new int[] {98,92,81,75}
            },
             new Student
            {
                Name = "Blok",
                Age=24,
                Scores = new int[] {92,91,88,79}
            },
              new Student
            {
                Name = "Clok",
                Age=25,
                Scores = new int[] {90,92,80,77}
            },
               new Student
            {
                Name = "Dlok",
                Age=26,
                Scores = new int[] {96,92,89,70}
            },
                new Student
            {
                Name = "Elok",
                Age=23,
                Scores = new int[] {92,92,81,75}
            },

        };
        var Query = from Student s in StudentList
                    where s.Scores[0] > 95
                    select s;

        foreach(Student st in Query)
        {
            Console.WriteLine(st.Name + ":" + st.Scores[0]);
        }
    }
}