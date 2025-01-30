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
                string [] readData = File.ReadAllLines(profile);
                foreach (string read in readData) {

                    string[] userData = read.Split(' ');
                    if (userData[3] == "true") { 
                        name.Text= userData[0];
                        email.Text= userData[1];
                        password.Text= userData[2]; 
                        flag.Text= userData[3]; 

                    return;
}



                }
               
            }
        }
    }
}