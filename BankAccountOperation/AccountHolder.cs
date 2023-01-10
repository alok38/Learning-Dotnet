using System;

namespace BankAccountOperation
{
    class AccountHolder
    {
        private Account[] accounts;
        private static int counter = 0;

        public AccountHolder()
        {
            accounts = new Account[10];
        }

        public void CreateAccount(string name, float amount, AccountType type)
        {
            accounts[counter++] = new Account(name, amount, type);
        }

        public void PrintAllAccounts()
        {
            foreach (Account a in accounts)
            {
                if (a != null)
                    a.printAccount();
                else
                    break;
            }
        }

        public bool isValidAccount(int accountNo)
        {
            foreach (Account a in accounts)
            {

                if (a != null)
                {
                    if (a.AccountNumber == accountNo)
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool DepositAmount(int account_no, float amount)
        {
            foreach (Account a in accounts)
            {
                if (a != null)
                {
                    if (a.AccountNumber == account_no)
                    {
                        a.Deposit(amount);
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Account Number");
                    break;
                }

            }

            return false;
        }

        public bool WithdrawAmount(int account_no, float amount)
        {
            foreach (Account a in accounts)
            {
                if (a != null)
                {
                    if (a.AccountNumber == account_no)
                    {
                        a.Withdraw(amount);
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid Account Number");
                    break;
                }

            }
            return false;
         }
        }
    }
