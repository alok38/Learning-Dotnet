using System;


namespace Employee_Polymorpism
{
    class Employee
    {
        protected static int id = 101;
        public readonly int empId;
        protected string name;
        protected decimal basic;
        protected decimal da;
        protected decimal hra;
        public Employee(string name, decimal basic, decimal da, decimal hra)
        {
            this.empId = id++;
            this.name = name;
            this.basic = basic;
            this.da = da;
            this.hra = hra;
        }
        public virtual decimal TotalSalary
        {
            get
            {
                return this.basic + this.da + this.hra;
            }
        }
        public virtual string printSalarySlip()
        {
            return string.Format("SalarySlip:\nEmployee Id: {0}\nEmployee Name: {1}\nBasic Salary: {2}\nDearness Allowance: {3}\nHra: {4}", this.empId, this.name, this.basic, this.da, this.hra, this.TotalSalary);
        }

    }
    class Hr : Employee
    {
        private decimal _hrAllowance;
        public Hr(string name, decimal basic, decimal da, decimal hra, decimal allowance) : base(name, basic, da, hra)
        {

            this._hrAllowance = allowance;
        }
        public override decimal TotalSalary
        {
            get
            {
                return this.basic + this.da + this.hra + this._hrAllowance;
            }
        }
        public override string printSalarySlip()
        {
            return string.Format("{0} \nHr Allowance: {1}\nTotal Salary: {2}", base.printSalarySlip(), this._hrAllowance, this.TotalSalary);
        }
    }
    class Admin : Employee
    {
        private decimal _adminAllowance;
        public Admin(string name, decimal basic, decimal da, decimal hra, decimal allowance) : base(name, basic, da, hra)
        {

            this._adminAllowance = allowance;
        }
        public override decimal TotalSalary
        {
            get
            {
                return this.basic + this.da + this.hra + this._adminAllowance;
            }
        }
        public override string printSalarySlip()
        {
            return string.Format("{0} \nAdmin Allowance: {1}\nTotal Salary: {2}", base.printSalarySlip(), this._adminAllowance, this.TotalSalary);
        }
    }
    class Software : Employee
    {
        private decimal _projectAllowance;
        public Software(string name, decimal basic, decimal da, decimal hra, decimal allowance) : base(name, basic, da, hra)
        {

            this._projectAllowance = allowance;
        }
        public override decimal TotalSalary
        {
            get
            {
                return this.basic + this.da + this.hra + this._projectAllowance;
            }
        }
        public override string printSalarySlip()
        {
            return string.Format("{0} \nProject Allowance: {1}\nTotal Salary: {2}", base.printSalarySlip(), this._projectAllowance, this.TotalSalary);
        }
    }
}
