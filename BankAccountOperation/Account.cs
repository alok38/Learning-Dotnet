using System;
namespace BankAccountOperation
{
    public enum AccountType
    {
        Current = 1,
        Savings,
        Business,
        Loan
    }
    class Account
    {
        private static int No = 101;
        private int _accountNumber;
        private string _accountHolderName;
        private float _accountBalance;
        private AccountType _accountType;

        public int AccountNumber { get { return this._accountNumber; } }

        public Account(string name, float amount, AccountType type)
        {
            this._accountNumber = No++;
            this._accountHolderName = name;
            this._accountBalance = amount;
            this._accountType = type;

        }
        public void Deposit(float amount)
        {
            this._accountBalance += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount <= this._accountBalance)
            {
                // Perform operations
                this._accountBalance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void printAccount()
        {
            Console.WriteLine("Name of Account Holder is : {0} \n Total Balance is RS : {1} \n Type of Account is : {2}", this._accountHolderName, this._accountBalance, this._accountType);
            Console.WriteLine("------------------------\n");
        }
    }
}
