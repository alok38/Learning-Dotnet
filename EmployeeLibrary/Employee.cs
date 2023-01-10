using PrintingServiceLib;
namespace EmployeeLibrary
{
    public class Employee
    {
       private int _empId;
      private  string _name;
       private int _basic, _da, _hra;
        public Employee(int empId, string name, int basic, int da, int hra)
        {
           this._empId = empId;
           this._name = name;
            this._basic = basic;
            this._da = da;
            this._hra = hra;
        }
        private int Salary
        {
            get
            {
                return _basic +_da + _hra;
            }
        }
        private void SalarySlip()
        {
            Console.WriteLine("Emp id {0}",this._empId);
            Console.WriteLine("Emp name {0}", this._name);
            Console.WriteLine("Emp salary {0}", this.Salary);
        }
        public void GenerateSalarySlip()
        {
            PrintingService.Print(SalarySlip);
        }
    }
}