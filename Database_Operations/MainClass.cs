using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Operations
{
    public class MainClass

    {
        static void Connected_Automatically()
        {
            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            SqlConnection objconn = new SqlConnection();
            objconn.ConnectionString = strConn;

            SqlCommand objcmd = new SqlCommand();
            string strCmd = @"Select * From Employees";
            objcmd.Connection = objconn;
            objcmd.CommandType = CommandType.Text;
            objcmd.CommandText = strCmd;

            SqlDataReader reader;
            objconn.Open();
           
            reader = objcmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            objconn.Close();
            Console.Write("ID");
            Console.Write("\tName");
            Console.Write("\t  Salary");
            Console.WriteLine("\tDeptID");
            Console.WriteLine("------------------------------------------------");

            foreach (DataRow row in dt.Rows)
            {
                Console.Write(row[0]);
                Console.Write("\t" + row["Name"]);
                Console.Write("\t" + row["Salary"]);
                Console.WriteLine("\t" + row["DID"]);
            }
            Console.WriteLine("***********************************************");
           
        }
        static void Connected()
        {
            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            SqlConnection objconn = new SqlConnection();
            objconn.ConnectionString = strConn;

            SqlCommand objcmd = new SqlCommand();
            string strCmd = @"Select * From Employees";
            objcmd.Connection = objconn;
            objcmd.CommandType = CommandType.Text;
            objcmd.CommandText = strCmd;

            SqlDataReader reader;
            objconn.Open();
            reader = objcmd.ExecuteReader();
            Console.Write("ID");
            Console.Write("\tName");
            Console.Write("\t  Salary");
            Console.WriteLine("\tDeptID");
            Console.WriteLine("--------------------------------------------");

            while (reader.Read())
            {
                Console.Write(reader[0]);
                Console.Write("\t" + reader["Name"]);
                Console.Write(reader["Salary"]);
                Console.WriteLine("\t" + reader["DID"]);
            }
            Console.WriteLine("**********************************************");
            reader.Close();
            objconn.Close();
        }
        static void Disconnected()
        {
            string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            SqlConnection objConn = new SqlConnection(strConn);

            SqlCommand objcmd = new SqlCommand();
            string strCmd = @"Select * From Employees";
            objcmd.Connection = objConn;
            objcmd.CommandType =CommandType.Text;
            objcmd.CommandText = strCmd;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = objcmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Employees");
            DataTable empTable = ds.Tables["Employees"];

            Console.Write("ID");
            Console.Write("\tName");
            Console.Write("\t  Salary");
            Console.WriteLine("\tDeptID");
            Console.WriteLine("--------------------------------------------");
            foreach(DataRow dr in empTable.Rows)
            {
                Console.Write(dr[0]);
                Console.Write("\t" + dr["Name"]);
                Console.Write(dr["Salary"]);
                Console.WriteLine("\t" + dr["DID"]);
            }
            Console.WriteLine("***********************************************");
        }
        static void Main(string[] args)
        {
            // string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=Welcome123$";
            ////string strConn = @"Data Source=PRSQL;Initial Catalog=MyDatabase;User ID=labuser;Password=***********";
            //SqlConnection conn = new SqlConnection(strConn);
            //conn.Open();
            //Console.WriteLine("Hello");
            //conn.Close();
            // Connected();
            // Disconnected();
            Connected_Automatically();
            Console.ReadLine();
        }
    }
}
