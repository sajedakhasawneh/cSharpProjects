using System;
using System.IO;
using System.Linq;
using System.Web.UI;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Orange\\Desktop\\C#projects\\project1\\project1\\sign.txt";
            string userInput = Email.Text.Trim(); // Trim to remove unnecessary spaces

            if (string.IsNullOrEmpty(userInput))
            {
                Response.Write("Email cannot be empty!");
                return;
            }

            // Check if file exists and email already exists
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Contains(userInput))
                {
                    Response.Write("This email is already registered.");
                    return;
                }
            }

            // Append the email to the file if it's not already there
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(userInput);
            }

            Response.Write("Email successfully registered!");
        }

        protected void ButtonReadFile_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Orange\\Desktop\\C#projects\\project1\\project1\\sign.txt";

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                FileContent.InnerText = content;
            }
            else
            {
                Response.Write("File not found!");
            }
        }

        protected void redicrect(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Orange\\Desktop\\C#projects\\project1\\project1\\sign.txt";

            if (File.Exists(filePath))
            {
                Response.Redirect(filePath);
            }
            else
            {
                Response.Write("File not found!");
            }
        }


        protected void login(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Orange\\Desktop\\C#projects\\project1\\project1\\sign.txt";
            string userInput = Email.Text.Trim();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Contains(userInput))
                {
                    Response.Write("Login successful!");
                }
                else
                {
                    Response.Write("Invalid email! Please register first.");
                }
            }
            else
            {
                Response.Write("File not found! No registered users.");
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            // Placeholder for page load logic
        }
    }
}