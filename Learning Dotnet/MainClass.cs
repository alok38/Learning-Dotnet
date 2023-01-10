using System;
class MainClass {
    static void addition(int a, int b)
    {
        int c = a + b;
        Console.WriteLine("the sum is " + c);
    }
    static void comparison(int a, int b)
    {
        if (a > b)
        {
            Console.WriteLine(a + " is greater than " + b);
        }
        else
        {
            Console.WriteLine(b + " is greater than " + a);
        }
    }
    static void swapping(int a, int b)
    {
        Console.WriteLine("before swapping X: " + a + " Y: " + b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("after swapping X: " + a + " Y: " + b);
    }
    static void printTable(int a, int b)
    {
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + "*" + j + "=" + i * j + "\n");
            }
        }
    }
    public static void Main(string[] args)
    {
        string a = "y";
        while (a != "n")
        {

            Console.WriteLine("enter first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operation to perform: \n 1.Addition \n 2.Comparison \n 3.swapping \n 4.Print Table");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addition(x, y);
                    break;
                case 2:
                    comparison(x, y);
                    break;
                case 3:
                    swapping(x, y);
                    break;
                case 4:
                    printTable(x, y);
                    break;
                default:
                    Console.WriteLine("please enter a correct choice");
                    break;
            }
            Console.WriteLine("perform operation again?(y/n)");
            a = Console.ReadLine();
        }
    }
}