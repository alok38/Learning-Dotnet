using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee_Department_WebApp
{
    public partial class TableView : System.Web.UI.Page
    {
        string strConn;
        SqlConnection objConn;
        string Cmd,Cmd2;
        SqlCommand objCmd,objCmd2;
        SqlDataReader dr;
        SqlDataReader drEmployee;
        private int selectedDeptID;
        protected void Page_Load(object sender, EventArgs e)
        {
            strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            objConn = new SqlConnection(strConn);
            Cmd = @"Select * From Departments";


            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            objCmd2 = new SqlCommand();
            objCmd2.Connection = objConn;
            objCmd.CommandText = Cmd;
            
            objConn.Open();
            dr = objCmd.ExecuteReader();
            //drEmployee = objCmd2.ExecuteReader();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            objConn.Close();
            
            selectedDeptID = int.Parse(GridView2.SelectedDataKey.Value.ToString());


            objConn.Open();
            
            Cmd2 = "select e.Name as EmployeeName,e.Salary as EmployeeSalary" +
             ", d.DeptName as DepartmentName from Employees e join Departments d on e.DID = d.DID where e.DID = " + selectedDeptID;
            objCmd2.CommandText = Cmd2;
            drEmployee = objCmd2.ExecuteReader();
                DataTable dt2 = new DataTable();
                dt2.Load(drEmployee);
                GridView1.DataSource = dt2;
                GridView1.DataBind();
            //decimal sal = decimal.Parse(new SqlCommand("Select Sum(Salary) from Employees where DID=" + selectedDeptID + "'", objConn).ExecuteScalar().ToString());
            lbl1.Text = "Total Salary in Department is: " + new SqlCommand("Select Sum(Salary) from Employees where DID= '" + selectedDeptID + "'", objConn).ExecuteScalar();
            lbl2.Text = "Total Employees in Department is: " + new SqlCommand("Select count(Salary) from Employees where DID= '" + selectedDeptID + "'", objConn).ExecuteScalar(); 

        }

        protected void BtnShow_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(dr);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            objConn.Close();
        }
    }
}