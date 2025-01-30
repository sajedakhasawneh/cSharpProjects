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
            //bool flag=false;
            for (int i = 0; i < uData.Length; i++)
            {
                string[] Data = uData[i].Split(' ');
                if (email.Text == Data[1] && password.Text == Data[2])
                {
                    //char[] toTrim = {'@'};
                    string user = Data[1];
                    //string value = user.Trim(toTrim);
                    if (user == "admin@gmail.com")
                    {
                        result.Text = "login successfully";
                        result.Visible = true;
                        Data[i] = $"{Data[0]} {Data[1]} {Data[2]} true";
                        File.WriteAllLines(Server.MapPath("file.txt"), uData);
                        Response.Redirect("adminpage.aspx");
                    }
                    else {

                        result.Text = "login successfully";
                        result.Visible = true;
                        Data[i] = $"{Data[0]} {Data[1]} {Data[2]} true";
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