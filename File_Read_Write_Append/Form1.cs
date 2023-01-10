using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Read_Write_Append
{
    public partial class frmOperations : Form
    {
        public frmOperations()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(@"D:\New folder\" + txtFileName.Text + ".txt");
            StreamWriter sw = f.CreateText();
            sw.WriteLine(txtText.Text);
            sw.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            int FileChar;
            sr = File.OpenText(@"D:\New folder\" + txtFileName.Text + ".txt");
            while((FileChar = sr.Read()) != -1)
            {
                txtFileContents.Text+=Convert.ToChar(FileChar);
            }
            sr.Close();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"D:\New folder\" + txtFileName.Text + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter s = new StreamWriter(fs);
            s.BaseStream.Seek(-1, SeekOrigin.End);
            txtFileContents.Text = String.Empty;
            s.WriteLine(txtNewText.Text);
            s.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
