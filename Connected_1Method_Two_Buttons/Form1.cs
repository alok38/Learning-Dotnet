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

namespace Connected_1Method_Two_Buttons
{
    public partial class Form1 : Form
    {
        string strConn;
        SqlConnection objConn;
        string Cmd;
        SqlCommand objCmd;
        SqlDataReader dr;
        bool flag;
        public Form1()
        {
            InitializeComponent();
            strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            objConn = new SqlConnection(strConn);
            Cmd = @"Select * From Employees";

            objCmd = new SqlCommand();
            objCmd.Connection = objConn;
            objCmd.CommandText = Cmd;

            objConn.Open();
            dr = objCmd.ExecuteReader();
            flag = true;
        }
        private void End()
        {
            dr.Close();
            objConn.Close();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if(sender == btnDisplay)
            {
                if (flag)
                {
                    if (objConn.State == ConnectionState.Closed)
                    {
                        objConn.Open();
                        dr = objCmd.ExecuteReader();
                    }
                    if (dr.Read())
                    {
                        textBox1.Text = dr["ID"].ToString();
                        textBox2.Text = dr["Name"].ToString();
                        textBox3.Text = dr["Salary"].ToString();
                       
                        flag = false;
                    }
                }

            }
            else if(sender == btnNext)
            {
                if (dr != null && !dr.IsClosed)
                {
                    if (dr.Read())
                    {
                        textBox1.Text = dr["ID"].ToString();
                        textBox2.Text = dr["Name"].ToString();
                        textBox3.Text = dr["Salary"].ToString();
                        
                    }
                    else
                    {
                        End();
                        MessageBox.Show("All Records Displayed");
                    }
                }
                else
                {
                    MessageBox.Show("Click Display button First");
                    flag = true;
                }
            }
        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
            dataGridView1.Columns["ID"].HeaderText = "EmpID";
            dataGridView1.Columns["Name"].HeaderText = "EmpName";
        }
    }
}
