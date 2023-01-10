
using System;
namespace AccountAssignment
{
    public class MainClass
    {
        static char option;
        static int accountNumber;
        static int amount;
        static byte choice;
        static string name;
        static string type;
        static int Initialbalance;
        static int counter = 0;

        static Account[] account = new Account[10];

        public static bool validation(int accNo)
        {
            for (int i = 0; i < counter; i++)
            {
                if (accNo == account[i].AccountNumber)
                {
                    return true;
                }
            }
            return false;
        }

        static void Input()
        {
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Type");
            type = Console.ReadLine();
            Console.WriteLine("Enter Initial Account Balance");
            Initialbalance = int.Parse(Console.ReadLine());
        }

        static void main()
        {

            Console.WriteLine("Which Service you would like to Use\n1. Create an Account\n2. Deposit\n3. Withdraw\n4. Print All Account Details\n5. Exit");
            do
            {
                Console.WriteLine("Enter your choice");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Input();
                        account[counter++] = new Account(name, type, Initialbalance);
                        Console.WriteLine("Congratulations ! Your Account has been successfully created , Your Account Number is {0}", account[counter - 1].AccountNumber);
                        break;

                    case 2:
                        Console.WriteLine("Enter the Account you want to do transaction");
                        accountNumber = int.Parse(Console.ReadLine());

                        if (validation(accountNumber))
                        {
                            Console.WriteLine("Enter the amount you want to deposit");
                            amount = int.Parse(Console.ReadLine());
                            account[accountNumber - 1001].deposit(amount);


                        }
                        else
                        {
                            Console.WriteLine("Kindly! Enter a valid account number");

                        }
                        break;


                    case 3:
                        Console.WriteLine("Enter the Account you want to do transaction");
                        accountNumber = int.Parse(Console.ReadLine());

                        if (validation(accountNumber))
                        {
                            Console.WriteLine("Enter the amount you want to withdraw");
                            amount = int.Parse(Console.ReadLine());
                            account[accountNumber - 1001].withdraw(amount);
                            // Console.WriteLine("{0} Rupees Withdrawn Successfully",amount);
                        }
                        else
                        {
                            Console.WriteLine("Kindly! Enter a valid account number");

                        }
                        break;
                    case 4:
                        for (int i = 0; i < counter; i++)
                        {
                            Console.WriteLine(account[i].printDetails());
                            Console.WriteLine("----------------");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Thank you for using our Services");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Kindly enter a valid option");
                        break;

                }
                Console.WriteLine("Do you want to continue...");
                option = char.Parse(Console.ReadLine());
                //Console.Clear();
            } while (option == 'y' || option == 'Y');
        }
        public static void Main(string[] args)
        {
            main();
        }
    }
}