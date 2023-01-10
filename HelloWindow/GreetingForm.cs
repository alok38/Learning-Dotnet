using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindow
{
    public partial class frmGreeting : Form
    {
        public frmGreeting()
        {
            InitializeComponent();
        }

       /*private void btnHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi " + txtName.Text +" you clicked "+ btnHi.Name);
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + txtName.Text +" You clicked " + btnHello.Name);
        }*/
       public void GreetMe(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            MessageBox.Show(txtName.Text + " clicked " + c.Name  );
        }
    }
}
