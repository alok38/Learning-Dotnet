using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie_WebApp
{
    public partial class ServerSide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br>Session ID: " + Session.SessionID);
            if (!this.IsPostBack)
            {
               



                if (Session.IsNewSession)
                {
                    Application.Lock();
                    Application["Application_Count"] = (int)Application.Count + 1;
                    
                    //Session.Count = (int)Session.Count + 1;
                    Session["Session_Count"] = (int)Session.Count + 1;
                    Application.UnLock();
                }



               
            }



            TextBox1.Text = "Session Count : " + Session.Count.ToString();
            TextBox2.Text = "Application Count : " + Application.Count.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.ASPX");
        }
    }
}