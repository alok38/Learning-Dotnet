namespace CustomException
{
    class MainClass
    {
        static void M()
        {
            int a = 10, b = 0;
            if (b > 0)
            {
                Console.WriteLine(a/b);
            }
            else
            {
                throw new MyException("Exception Occured", new DivideByZeroException());
            }
        }
        static void Main()
        {
            try
            {
                M();
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("======================");
        }
    }
}