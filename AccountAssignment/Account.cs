using System;

namespace AccountAssignment
{
    class Account
    {
        public static int number = 1001;
        private int _accountNumber;
        private string _customerName;
        private string _accountType;
        private int _accountBalance;

        public Account(string _customerName, string _accountType, int _accountBalance)
        {
            this._accountNumber = number++;
            this._customerName = _customerName;
            this._accountType = _accountType;
            this._accountBalance = _accountBalance;
        }

        public int AccountNumber
        {
            get
            {
                return this._accountNumber;
            }
        }
        public void deposit(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Enter a valid amount");
            }
            else
            {

                _accountBalance += amount;
                Console.WriteLine("{0} Rupees Deposited Successfully", amount);
            }
        }

        public void withdraw(int amount)
        {
            if (amount > _accountBalance || amount < 0)
            {
                Console.WriteLine("Enter a valid amount");
            }
            else
            {
                _accountBalance -= amount;
                Console.WriteLine("{0} Rupees withdrawn Successfully", amount);
            }

        }
        public string printDetails()
        {
            return String.Format("Account Number :{0}\nCustomer Name :{1}\nAccount Type :{2}\nAccount Balance :{3}", this._accountNumber, this._customerName, this._accountType, this._accountBalance);
        }

    }
}
