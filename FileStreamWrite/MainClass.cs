using System.IO;

class MainClass
{
    static void Main()
    {
        FileStream fs = new FileStream(@"D:\New folder\abc.txt", FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("hello");
        sw.Close();
        fs.Close();
    }
}