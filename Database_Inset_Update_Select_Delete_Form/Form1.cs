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

namespace Database_Inset_Update_Select_Delete_Form
{
    public partial class EmployeeForm : Form
    {
        SqlConnection objConn;
        SqlCommand objCmd;
        SqlDataReader dr;
        //IDataReader dr;
        string strCmd;
        string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";

        public EmployeeForm()
        {

            InitializeComponent();
            objConn = new SqlConnection(strConn);
            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            strCmd = @"Select * From Employees";
            objCmd.CommandText = strCmd;

            objConn.Open();
            dr = objCmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            objConn.Close();

            dgvEmployee.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            strCmd = @"Insert Into Employees values('" + txtName.Text + "','" + txtSalary.Text + "','" + txtDeptID.Text + "')";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + " Records Inserted");
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            strCmd = @"Update Employees Set Name = '" + txtName.Text + "', Salary ='" + txtSalary.Text + "', DID ='" + txtDeptID.Text+ "' Where ID = '"+ txtEmpID.Text + "' ";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + " Records Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            strCmd = @"Delete From Employees Where Salary>'"+txtSalary.Text+"'";
            objCmd.CommandText = strCmd;
            objConn.Open();
            int i = objCmd.ExecuteNonQuery();
            objConn.Close();
            MessageBox.Show(i + " Records Deleted");
        }
    }
}
