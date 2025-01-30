using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class userProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string file = Server.MapPath("file.txt");
            if (File.Exists(file))
            {
                string[] stringsData = File.ReadAllLines(file);
                foreach (string s in stringsData)
                {
                  
                    string [] lines = s.Split(' ');
                    if (lines.Length < 3)
                        continue;
                    if (lines[3] == "true")
                    {
                        name.Text = lines[0];
                        email.Text = lines[1];
                        password.Text = lines[2];
                        flag.Text = lines[3];
                        return;


                    }


                }
            }
        }
        protected void asktoedit_Click(object sender, EventArgs e)
        {
            Response.Redirect("editProfile.aspx");
        }
    }
}