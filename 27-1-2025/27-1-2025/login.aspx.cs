using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         

        }


        protected void login_Click(object sender, EventArgs e)
        {
            string userdata = Server.MapPath("file.txt");
            string[] uData = File.ReadAllLines(userdata);
            for (int i = 0; i < uData.Length; i++)
            {
                string[] Data = uData[i].Split(' ');
                if (email.Text == Data[1] && password.Text == Data[2])
                {
                    string user = Data[1];
                    if (user == "admin@gmail.com")
                    {
                        result.Text = "login successfully";
                        result.Visible = true;
                        uData[i] = $"{Data[0]} {Data[1]} {Data[2]} true";
                        File.WriteAllLines(Server.MapPath("file.txt"), uData);
                        Response.Redirect("adminpage.aspx");
                    }
                    else {

                        result.Text = "login successfully";
                        result.Visible = true;
                        uData[i] = $"{Data[0]} {Data[1]} {Data[2]} true";
                        File.WriteAllLines(Server.MapPath("file.txt"), uData);
                        Response.Redirect("studentpage.aspx");
                    }
                 
                }

                else
                {
                    result.Text = "Invalid username or password ";
                    result.Visible = true;

                }

            }
        }
    }
}