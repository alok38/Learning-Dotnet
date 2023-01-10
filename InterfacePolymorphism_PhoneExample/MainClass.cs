namespace InterfacePolymorphism_PhoneExample
{
    enum Os
    {
        Android = 1,
        Ios
    }
    public class MainClass
    {
        static IPhone[] phones = new IPhone[1];
        static int number;
        public static void Input()
        {
            Console.Write("Choose a function to perform: \n1.Make a Call\n2.switchOff Phone\n3.switchOn Phone\nEnter your choice: ");
        }
        public static void innerSwitch(int option)
        {
            switch (option)
            {
                case 1:
                    Console.Write("Enter Number to call: ");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine(phones[0].call(number));
                    break;
                case 2:
                    Console.WriteLine(phones[0].switchOff());
                    break;
                case 3:
                    Console.WriteLine(phones[0].switchOn());
                    break;
            }
        }
        public static void Main(string[] args)
        {
            int option, innerOption;
            string choice;
            do
            {

                Console.Write("Which Phone would you like to use?\n1.Android\n2.Ios\nEnter Your Choice: ");
                option = int.Parse(Console.ReadLine());
                switch ((Os)option)
                {
                    case Os.Android:
                        phones[0] = new Android();
                        Input();
                        innerOption = int.Parse(Console.ReadLine());
                        innerSwitch(innerOption);
                        break;
                    case Os.Ios:
                        phones[0] = new Ios();
                        Input();
                        innerOption = int.Parse(Console.ReadLine());
                        innerSwitch(innerOption);
                        break;
                }
                Console.Write("Continue?(Y/N): ");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "Y");
        }
    }
}