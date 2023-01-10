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

namespace AutoUpdate_Disconnected_Type
{
    public partial class Form1 : Form
    {
        SqlConnection objConn;
        SqlCommand objCmd;
        SqlDataAdapter da;
        string strCmd;
        string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
        SqlCommandBuilder  cmdBuilder;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            objConn = new SqlConnection(strConn);
            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            string strCmd = @"Select * From Employees";

            da = new SqlDataAdapter();
            da.SelectCommand = objCmd;
            objCmd.CommandType = CommandType.Text;
            objCmd.CommandText = strCmd;
            cmdBuilder = new SqlCommandBuilder(da);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
            dgvEmployees.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            da.Update(dt);
        }
    }
}
