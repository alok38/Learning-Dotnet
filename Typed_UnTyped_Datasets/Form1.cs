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

namespace Typed_UnTyped_Datasets
{
    public partial class Form1 : Form
    {
        DataSet ds;
        SqlCommand ObjCmd;
        SqlConnection Objconn;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
            string strconn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            Objconn = new SqlConnection(strconn);
            string strcmd = "Select * from Employees";
            ObjCmd = new SqlCommand(strcmd, Objconn);
            da = new SqlDataAdapter();
            da.SelectCommand = ObjCmd;
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            ds = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1 etds = new DataSet1();
            da.Fill(etds, "Employees");
            textBox1.Text = etds.Employees[1].Name;
            // etds.Employees[0].ID = "2";  // directly error as the type took is int and passed string
            //   da.Update(etds.Tables["Employees"]);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            da.Fill(ds, "Employees");
            textBox1.Text = (string)ds.Tables["Employees"].Rows[0]["Name"];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employees";
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["Employees"];
            DataRow row = dt.Rows[2];
            row["ID"] = "Alok"; // runtime exception showing while trying to fetch data from sql database
            da.Update(ds.Tables["Employees"]);
            MessageBox.Show((string)ds.Tables["Employees"].Rows[2]["ID"]);
        }
    }
}
