using System;
namespace ExceptionHandlingWithIfElse
{
    class MainClass
    {
        public static void M()
        {
            try
            {
                int i = 10;
                int j = 0;
                if (j == 0)
                {
                    throw new DivideByZeroException("Second Argument is Zero");
                }
                else
                {
                    int k = i / j;
                }
            }
            catch (DllNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally in M");
            }
            Console.WriteLine("after finally in M");
        }
        public static void Main()
        {
            try
            {
                M();

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("inside Divide by zero Exception");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally in main");

            }
            Console.WriteLine("code at end");
        }
    }
}