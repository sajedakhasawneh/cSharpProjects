using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            string userdata = Server.MapPath("file.txt");

            if (!File.Exists(userdata)) {
                using (StreamWriter streamWriter = File.CreateText(userdata))
                {
                    streamWriter.WriteLine($"{name.Text} {email.Text} {password.Text}");
                }
                Response.Redirect("login.aspx");
            }

            else
            {
                using (StreamWriter writer =  new StreamWriter (userdata,true))
                {
                    writer.WriteLine($"{name.Text} {email.Text} {password.Text}");
                }
                Response.Redirect("login.aspx");
            }

            

        }
    }
}