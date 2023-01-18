using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Cookie_WebApp
{
    public partial class ReadCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Read Cookie.Aspx is loaded");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                //HttpCookie objCookie = new HttpCookie("myCookie");
                HttpCookie objCookie = Request.Cookies["myCookie"];
           // HttpCookie objCookie = Request.Cookies{"myCookie"};
            lblTime.Text = objCookie.Values["Time"];
            lblTime.ForeColor = System.Drawing.Color.FromName(objCookie.Values["ForeGroundColor"]);
            lblTime.BackColor = System.Drawing.Color.FromName(objCookie.Values["BackGroundColor"]);

            lblCurrentTime.Text = DateTime.Now.ToString();
        }
    }
}