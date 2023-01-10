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

namespace Select_Next_Form
{
    public partial class Form1 : Form
    {
        string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
        SqlConnection objConn;
        string strSelect = @"Select * From Employees";
        string strCmd;
        SqlCommand Select,Cmd;
        SqlDataReader dr;
        bool flag = true;


        public Form1()
        {
            objConn = new SqlConnection(strConn);
            Select = new SqlCommand(strSelect,objConn);
            Cmd = new SqlCommand();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if(objConn.State == ConnectionState.Closed)
                {
                    objConn.Open();
                    dr = Select.ExecuteReader();
                }
                if (dr.Read())
                {
                    textBox1.Text = dr["ID"].ToString();
                    textBox2.Text = dr["Name"].ToString();
                    textBox3.Text = dr["Salary"].ToString();
                    textBox4.Text = dr["DID"].ToString();
                    flag = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dr != null && !dr.IsClosed)
            {
                if (dr.Read())
                {
                    textBox1.Text = dr["ID"].ToString();
                    textBox2.Text = dr["Name"].ToString();
                    textBox3.Text = dr["Salary"].ToString();
                    textBox4.Text = dr["DID"].ToString();
                }
                else
                {
                    dr.Close();
                    objConn.Close();
                    MessageBox.Show("All Records Displayed");
                }
            }
            else
            {
                MessageBox.Show("Click Select button First");
                flag = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }
            if(dr!= null && !dr.IsClosed)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
                objConn.Close();

            }
            else
            {
                dr = Select.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dr.Close();
                objConn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            strCmd = @"Update Employees Set Name = '" + textBox2.Text + "', Salary ='" +textBox3.Text + "', DID ='" + textBox4.Text + "' Where ID = '" + textBox1.Text + "' ";
            Cmd.CommandText = strCmd;
            Cmd.Connection = objConn;
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
                dr.Close();
            }
            MessageBox.Show(Cmd.ExecuteNonQuery().ToString() + " Records Updated");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            strCmd = @"Delete from Employees where ID='" + textBox1.Text + "'";
            Cmd.CommandText = strCmd;
            Cmd.Connection = objConn;
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }
            if (dr != null && !dr.IsClosed)
            {
                dr.Close();
            }
            MessageBox.Show(Cmd.ExecuteNonQuery().ToString() + " Records Deleted");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            strCmd = @"Insert Into Employees values('"+ textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            Cmd.CommandText = strCmd;
            Cmd.Connection = objConn;
            if(objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
            }
            if(dr != null && !dr.IsClosed)
            {
                dr.Close();
            }
            MessageBox.Show(Cmd.ExecuteNonQuery().ToString()+" Records Inserted");
        }

    }
}
