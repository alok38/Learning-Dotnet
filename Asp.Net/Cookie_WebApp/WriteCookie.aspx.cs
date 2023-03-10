using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie_WebApp
{
    public partial class WriteCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                HttpCookie objCookie = new HttpCookie("myCookie");
                DateTime now = DateTime.Now;
                objCookie.Values.Add("Time", now.ToString());
                objCookie.Values.Add("ForeGroundColor", "red");
                objCookie.Values.Add("BackGroundColor", "yellow");
                this.Response.Cookies.Add(objCookie);
            }
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Write("ReadCookie .aspx Loaded");
        }
    }
}