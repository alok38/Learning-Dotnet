using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello3
{
    public partial class PageLifeCycle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Load");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("init");
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("pre init");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Init completed");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Pre Render");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("PreLoad");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button clicked");
        }
    }
}