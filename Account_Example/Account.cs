using System;
namespace Account_Example
{
    internal class Account
    {
        static int id = 101;
        private string _customerName;
        private decimal _balance;
        private int _accountNumber;
        public Account(string name, decimal balance)
        {
            this._accountNumber = id++;
            this._customerName = name;
            this._balance = balance;
        }
        public string Deposit(decimal amount)
        {
            this._balance = this._balance + amount;
            return string.Format("{0} deposited", amount);
        }
        public string Withdraw(decimal amount)
        {
            if (this._balance >= amount)
            {
                this._balance = this._balance - amount;
                return string.Format("{0} withdrawn", amount);
            }
            else
            {
                return string.Format("insufficient balance");
            }
        }
        public int AccountNumber
        {
            get
            {
                return this._accountNumber;
            }
        }
        public decimal Balance
        {
            get
            {
                return this._balance;
            }
        }
        public string AccountSummary()
        {
            return string.Format("Account No:{0}\nName:{1}\nBalance:{2}", this._accountNumber, this._customerName, this._balance);
        }
    }
}
