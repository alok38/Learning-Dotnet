using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceConsumerHello.HelloService;
namespace ServiceConsumerHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorldSoapClient sh = new HelloWorldSoapClient();
            Console.WriteLine(sh.SayHello("Alok"));
        }
    }
}
