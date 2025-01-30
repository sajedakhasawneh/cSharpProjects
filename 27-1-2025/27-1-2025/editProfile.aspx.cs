using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class editProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void editprofile_Click(object sender, EventArgs e)
        {
            string profile = Server.MapPath("file.txt");
            if (File.Exists(profile))
            {
                string[] readData = File.ReadAllLines(profile);

                for (int i = 0; i < readData.Length; i++)
                {
                    string[] userData = readData[i].Split(' ');
                    if (userData[3] == "true")
                    {
                        readData[i] = $"{name.Text} {email.Text} {userData[2]} true";
                        //File.writeAllLines(profile, userData);
                        File.WriteAllLines(profile, readData);
                        //saved.Text = "saved!";
                    }
                }
            }
        }
    }
}