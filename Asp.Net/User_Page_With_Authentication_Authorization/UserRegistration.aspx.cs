using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Page_With_Authentication_Authorization
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyDAL MyData = new MyDAL();
            User u = new User();
            u.Name = txtName.Text.ToString();
            u.Age = int.Parse(txtAge.Text.ToString());
            u.Email = txtEmail.Text.ToString();
            u.Password = txtPassword.Text.ToString();
            MyData.Users.Add(u);
            MyData.SaveChanges();
            Response.Write("Registered Succesfully");
            
        }
    }
}