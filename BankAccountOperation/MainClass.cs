using System;
namespace BankAccountOperation
{
    public class MainClass
    {
        static bool toBeContiuned = true;

        public static void Main(string[] args)
        {

            AccountHolder accountHolder = new AccountHolder();
            int account_no = 0;
            float amount = 0f;
            AccountType type = AccountType.Current;
            Console.Write("Which Operation To Perform ? \n 1 : Create Account \n 2: PrintSummary \n 3 : Deposit \n 4 : Withdraw \n 5 : Exit \n");


            while (true)
            {
                Console.WriteLine("Enter Choice :  ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Create Account
                        Console.WriteLine("Enter Name Of Account Holder : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Initial Balance : ");
                        float balance = float.Parse(Console.ReadLine());

                        Console.WriteLine("Select The Type of Account \n 1 = Current \n 2 = Savings \n 3 = Business \n 4 = Loan");

                        int typeChoice = int.Parse(Console.ReadLine());
                        switch (typeChoice)
                        {
                            case 1:
                                type = AccountType.Current;
                                break;
                            case 2:
                                type = AccountType.Savings;
                                break;
                            case 3:
                                type = AccountType.Business;
                                break;
                            case 4:
                                type = AccountType.Loan;
                                break;
                            default:
                                break;

                        }
                        accountHolder.CreateAccount(name, balance, type);
                        break;
                    case 2: // Print All Accounts 
                        accountHolder.PrintAllAccounts();
                        break;
                    case 3: // Deposit
                        Console.WriteLine("Enter The Account Number to Deposit In : ");
                        account_no = int.Parse(Console.ReadLine());

                        if (accountHolder.isValidAccount(account_no))
                        {
                            Console.WriteLine("Enter The Amount to Deposit In Accoount Number {0}: ", account_no);
                            amount = float.Parse(Console.ReadLine());
                            accountHolder.DepositAmount(account_no, amount);
                        }
                        else
                        {
                            Console.WriteLine("Please Enter Valid Account Number");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter The Account Number to Withdraw from : ");
                        account_no = int.Parse(Console.ReadLine());
                        if (accountHolder.isValidAccount(account_no))
                        {
                            Console.WriteLine("Enter The Amount to Withdraw from Accoount Number {0}: ", account_no);
                            amount = float.Parse(Console.ReadLine());
                            accountHolder.WithdrawAmount(account_no, amount);
                        }
                        else
                        {
                            Console.WriteLine("Please Enter Valid Account NO");
                        }

                        break;
                    case 5: // Exit 
                        toBeContiuned = false;
                        break;
                    default:
                        toBeContiuned = false;
                        break;
                }

                if (!toBeContiuned)
                {
                    break;
                }

            }

        }

    }
}