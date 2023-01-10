namespace AbstractClass_Polymorphism_PhoneExample
{
    public class MainClass
    {
        static Phone[] phones = new Phone[10];
        static int option, innerOption, ram, storage, price, counter;
        static string processor;

        static void Input()
        {
            Console.WriteLine("Enter processor: ");
            processor = Console.ReadLine();
            Console.WriteLine("Enter Ram: ");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Storage: ");
            storage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price: ");
            price = int.Parse(Console.ReadLine());
        }
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.Write("select an option: \n1.Manufacture a phone\n2.Print all Phone details \n Enter Choice: ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Choose a company: \n1.Samsung\n2.Nokia\nYour Choice: ");
                        innerOption = int.Parse(Console.ReadLine());
                        switch (innerOption)
                        {
                            case 1:
                                Input();
                                phones[counter++] = new SamsungPhone(processor, ram, storage, price);
                                Console.WriteLine(phones[counter - 1].calculatePrice() + ": total price, Phone has been manufactured!");
                                break;
                            case 2:
                                Input();
                                phones[counter++] = new NokiaPhone(processor, ram, storage, price);
                                Console.WriteLine(phones[counter - 1].calculatePrice() + ": total price, Phone has been manufactured!");
                                break;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < counter; i++)
                        {
                            Console.WriteLine(phones[i].printPhoneDetails());
                        }
                        break;
                }
                Console.Write("Continue?(y/n): ");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "Y");

        }
    }
}
