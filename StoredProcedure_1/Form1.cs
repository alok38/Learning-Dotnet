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

namespace StoredProcedure_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStp1_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            SqlConnection objConn = new SqlConnection(strConn);
            
            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            objCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter P1 = new SqlParameter("DeptName", SqlDbType.NChar);
            P1.Direction = ParameterDirection.Input;
            P1.Value = "Software";

            objCmd.CommandText = "udstp_DepratmentWiseEmployees"; 
            objCmd.Parameters.Add(P1);

            DataTable dt = new DataTable();
            dgvEmployees.DataSource = dt;
            SqlDataReader dr;
            objConn.Open();
            dr = objCmd.ExecuteReader();
            dt.Load(dr);
            MessageBox.Show(dt.Rows.Count.ToString()+" Rows");
            dr.Close();
            objConn.Close();
        }

        private void btnStp2_Click(object sender, EventArgs e)
        {

            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            SqlConnection objConn = new SqlConnection(strConn);

            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            objCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter P1 = new SqlParameter("DeptName", SqlDbType.NChar);
            P1.Direction = ParameterDirection.Input;
            P1.Value = "Software";

            objCmd.CommandText = "udstp_TotalSalaryOfDepartment";
            objCmd.Parameters.Add(P1);

            DataTable dt = new DataTable();
            dgvEmployees.DataSource = dt;
            SqlDataReader dr;
            objConn.Open();
            dr = objCmd.ExecuteReader();
            dt.Load(dr);
            MessageBox.Show(dt.Rows.Count.ToString() + " Rows");
            dr.Close();
            objConn.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            SqlConnection objConn = new SqlConnection(strConn);

            SqlCommand objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            DataTable dt = new DataTable();
           string strCmd = @"Select * From Employees";
            objCmd.CommandText = strCmd;
            SqlDataReader dr;

            objConn.Open();
            dr = objCmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            objConn.Close();

            dgvEmployees.DataSource = dt;
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            SqlTransaction tr;
            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            SqlConnection objConn = new SqlConnection(strConn);
            objConn.Open();
            tr = objConn.BeginTransaction();

            try
            {
                new SqlCommand(@"Delete From Employees where ID = 113",objConn,tr).ExecuteNonQuery();
                int i = new SqlCommand(@"Insert Into Employees (Name,Salary,DID) values('oklok',20000,1)", objConn, tr).ExecuteNonQuery();
                MessageBox.Show("Transaction Successfull");
                if (i > 0)
                {
                    throw new Exception("Something wrong");
                }
                tr.Commit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                tr.Rollback();
            }
            finally
            {
                objConn.Close();
            }
        }
    }
}
