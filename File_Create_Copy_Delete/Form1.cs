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

namespace File_Create_Copy_Delete
{
    public partial class frmOperations : Form
    {
        public frmOperations()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            File.CreateText(@"D:\New folder\" + txtCreateFile.Text + ".txt");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete(@"D:\New folder\" + txtDeleteFile.Text + ".txt");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            File.Copy(@"D:\New folder\" + txtCreateFile.Text + ".txt", @"D:\New folder\" + txtCopyFile.Text + ".txt", true);
        }
    }
}
