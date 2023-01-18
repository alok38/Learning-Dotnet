using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Page_With_Authentication_Authorization
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            MyDAL md = new MyDAL();
            List<User> list = (from u in md.Users
                     where u.Name == (TextBox1.Text.ToString())
                     && u.Password == (TextBox2.Text.ToString())
                     select u).ToList();
            if(list.Count() == 1)
            {
                FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
            }
            else
            {
                Response.Write("credentials not matching");
            }
           /* if (UserID == UserID2)
            {
                Response.Write("matching");
               // FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
            }
            else
            {
                Response.Write("Sorry credentials are not matching");
            }*/
          
        }
    }
}