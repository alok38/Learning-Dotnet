using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFramework_DBFirst_WebApp
{
    public partial class DB_First_FetchData : System.Web.UI.Page
    {
        static MyDatabaseEntities mdEntities = new MyDatabaseEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           List<Employee> list =( from emp in mdEntities.Employees
                       select emp).ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            string name = TextBox2.Text.ToString();
            decimal salary = decimal.Parse(TextBox3.Text.ToString());
            short did = short.Parse(TextBox4.Text.ToString());
            Employee emp = new Employee
            {
                Name = name,
                Salary = salary,
                DID = did
            };
            mdEntities.Employees.Add(emp);
            mdEntities.SaveChanges();

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            short id = short.Parse(TextBox1.Text.ToString());
            string name = TextBox2.Text.ToString();
            decimal salary = decimal.Parse(TextBox3.Text.ToString());

            List<Employee> list = (from empl in mdEntities.Employees
                           where empl.ID == id
                           select empl).ToList();

            list[0].Salary = salary;
            list[0].Name = name;
            mdEntities.SaveChanges();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            short id = short.Parse(TextBox1.Text.ToString());
            List<Employee> list = (from empl in mdEntities.Employees
                                  where empl.ID == id
                                  select empl).ToList();
            mdEntities.Employees.Remove(list[0]);
            mdEntities.SaveChanges();
        }
    }
}