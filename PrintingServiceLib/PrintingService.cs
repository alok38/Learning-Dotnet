namespace PrintingServiceLib
{
    public delegate void PrintDelegate();
    public class PrintingService
    {
        public static void Print(PrintDelegate d)
        {
            d();
        }
    }
}