using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class editBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void editbook_Click(object sender, EventArgs e)
        {
            string bookToEdit = Server.MapPath("file.txt");

            string name = bookName.Text; // New book name
            string type = booktype.Text; // New book type
            string level = booklevel.Text; // New book level

           

            // Read all lines from the file into a List
            var bookDetails = File.ReadAllLines(bookToEdit).ToList();

            // Iterate and update the line with the matching ID
            for (int i = 0; i < bookDetails.Count; i++)
            {
                var data = bookDetails[i].Split(' ');

                // Ensure we trim whitespace for accurate comparison
                //if (data[0].Trim() == bookid.Text)
                //{
                //    bookDetails[i] = $"{bookid.Text}, {bookName.Text}, {booktype.Text}, {booklevel.Text}";
                //    File.WriteAllLines(bookToEdit, bookDetails);

                //    Editmessage.Text = " book successfully edited";
                //    Editmessage.Visible = true;
                //    Response.Redirect("adminbook.aspx");
                //    //return;
                //}
            }
        }
    }
}