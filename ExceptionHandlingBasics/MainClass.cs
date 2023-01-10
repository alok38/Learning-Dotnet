namespace ExceptionHandlingBasics
{
    class MainClass
    {
        static void M()
        {
            try
            {
                Console.Write("Enter First Number: ");
                int i = int.Parse(Console.ReadLine());
                Console.Write("Enter Second Number: ");
                int j = int.Parse(Console.ReadLine());
                Console.WriteLine(i / j);
            }
            catch (DllNotFoundException e)
            {
                Console.WriteLine("Dll is missing");
            }
            finally
            {
                Console.WriteLine("closing M");
            }
            Console.WriteLine("After finally block");
        }
        static void Main()
        {
        Repeat:
            
            try
            {
               M();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("secod argument is zero");
                Console.WriteLine(e.StackTrace);
                goto Repeat;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally in main");
            }
            Console.WriteLine("after finally in main");
        }
    }
}