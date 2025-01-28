using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signupbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("registration.aspx");
        }

        protected void loginbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");

        }
    }
}