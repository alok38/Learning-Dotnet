using System;
using System.IO;

namespace FileStreamRead
{
    class MainClass
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"D:\\New folder\\abc.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();
            Console.WriteLine("Text from the file: ");
            Console.WriteLine(str);
            sr.Close();
            fs.Close();
        }
    }
}