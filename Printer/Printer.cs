using DelegateLibrary;

namespace Printerlib
{
    
    public class Printer
    {
        public static void print(PrintDelegate p)
        {
            p();
        }
    }
}