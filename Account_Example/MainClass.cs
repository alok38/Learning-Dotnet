using System;
namespace Account_Example
{
    public class MainClass
    {
        static int index;
        static string name;
        static decimal balance;
        static int counter = 0;
        static Account[] accounts = new Account[10];
        static void Input()
        {
            Console.Write("enter name:");
            name = Console.ReadLine();
            Console.Write("enter initial balance:");
            balance = decimal.Parse(Console.ReadLine());
        }
        static bool searchAccount(int accountNumber)
        {
            for (index = 0; index < counter; index++)
            {
                if (accounts[index].AccountNumber == accountNumber)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {
            int selected, innerSelected;
            string option = "y";
            int accountNumber;
            decimal tempAmount;
            do
            {
                Console.Write("\nSelect Option:\n1.Create an Account\n2.Perform transaction in existing account\n3.View Existing Acounts\n4.Exit\nEnter your choice:");
                selected = int.Parse(Console.ReadLine());
                switch (selected)
                {
                    case 1:
                        Input();
                        accounts[counter++] = new Account(name, balance);
                        Console.WriteLine("\naccount created,account number: {0}", accounts[counter - 1].AccountNumber);

                        break;
                    case 2:
                        Console.Write("Enter account number");
                        accountNumber = int.Parse(Console.ReadLine());
                        if (searchAccount(accountNumber))
                        {
                            Console.Write("what action would you like to perform?\n1.Deposit\n2.Withdraw\n3.Balance enquiry\nenter a choice: ");
                            innerSelected = int.Parse(Console.ReadLine());
                            switch (innerSelected)
                            {
                                case 1:
                                    Console.Write("Enter Amount To Be Deposited:");
                                    tempAmount = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine(accounts[index].Deposit(tempAmount));
                                    break;
                                case 2:
                                    Console.Write("Enter Amount To Be De withdrawn:");
                                    tempAmount = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine(accounts[index].Withdraw(tempAmount));
                                    break;
                                case 3:
                                    Console.WriteLine(accounts[index].AccountSummary());
                                    break;

                                default:
                                    Console.WriteLine("Enter a valid choice");
                                    break;
                            }

                        }

                        else
                        {
                            Console.WriteLine("Incorrect Account Number");
                        }
                        break;

                    case 3:
                        for (int i = 0; i < counter; i++)
                        {
                            Console.WriteLine(accounts[i].AccountSummary());
                            Console.WriteLine("-----------------------");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thankyou!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a correct choice");
                        break;
                }
                Console.WriteLine("continue?(y/n)");
                option = Console.ReadLine();
            } while (option == "y" || option == "Y");
        }
    }
}