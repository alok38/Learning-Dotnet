namespace Indexer_Example
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Employee empObj = new Employee();
            empObj[0] = "alok";
            empObj[1] = "blok";
            empObj[2] = "clok";
            empObj[3] = "dlok";
            empObj[4] = "elok";
            for (int i = 0; i < Employee.size; i++)
            {
                Console.WriteLine(empObj[i]);
            }
            empObj["alok"] = 102;
            empObj["blok"] = 101;
            empObj["clok"] = 104;
            empObj["dlok"] = 103;
            empObj["elok"] = 105;
            for (int i = 0; i < Employee.size; i++)
            {
                Console.WriteLine(empObj[empObj[i]]);
            }

        }
    }

}