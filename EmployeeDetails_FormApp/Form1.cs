using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDetails_FormApp
{
    public partial class Form1 : Form
    {

        string strConn;
        SqlConnection objConn;
        string Cmd;
        SqlCommand objCmd;
        SqlDataReader dr;
        SqlDataReader drEmployee;
        DataTable dtEmployees;
        private int selectedDeptID;

        public Form1()
        {
            InitializeComponent();
            strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            objConn = new SqlConnection(strConn);
            Cmd = @"Select * From Departments";


            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = Cmd;

            objConn.Open();
            dr = objCmd.ExecuteReader();
            dtEmployees = new DataTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
             objConn.Close();
        }

        private void MyFunc(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            DataGridViewCellCollection cells = row.Cells;
            selectedDeptID = int.Parse(cells[0].Value.ToString());
           string cmdText = "select e.Name as EmployeeName,e.Salary as EmployeeSalary" +
                ", d.DeptName as DepartmentName from Employees e join Departments d on e.DID = d.DID where e.DID = " + selectedDeptID;
            objCmd.CommandText = cmdText;

            if (objConn.State != ConnectionState.Closed)
            {

            }
            else
            {
                objConn.Open();
                drEmployee = objCmd.ExecuteReader();
                dtEmployees.Clear();
                dtEmployees.Load(drEmployee);
                dataGridView1.DataSource = dtEmployees;
                objConn.Close();
                 
                int count = 0;
                string deptname = "";
                double totalsalary = 0;
               
                foreach (DataRow dr in dtEmployees.Rows)
                {
                    totalsalary += double.Parse(dr.ItemArray[1].ToString());
                    count++;
                    deptname = dr.ItemArray[2].ToString();
                }
                label2.Text = string.Format("Total Employees in {0}  Department are {1}", deptname, count);
                label3.Text = string.Format("Total Salary  Distributed in {0} Department is {1}", deptname, totalsalary);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
