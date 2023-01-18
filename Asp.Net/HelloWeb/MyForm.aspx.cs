using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class MyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("hello");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Clicked");
        }
    }
}