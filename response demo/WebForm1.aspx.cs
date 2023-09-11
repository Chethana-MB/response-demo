using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace response_demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for(int i=0;i<100;i++)
            {
                Response.Write("<img src=green.jpg>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<marquee><h2>Welcome to first website</h2></marquee>");
        }
    }
}