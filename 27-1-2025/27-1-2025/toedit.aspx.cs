using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class toedit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Edit_Click(object sender, EventArgs e)
        {
            string bookToEdit = Server.MapPath("file.txt");
            string[] bookData = File.ReadAllLines(bookToEdit);

            foreach (string book in bookData)
            {
                string[] Data = book.Split(' ');
                if (bookid.Text == bookData[2])
                {
                    Response.Redirect("editBook.aspx");
                }


            }






            //// Read all lines from the file into a List
            //var bookDetails = File.ReadAllLines(bookToEdit).ToList();

            //// Iterate and update the line with the matching ID
            //for (int i = 0; i < bookDetails.Count; i++)
            //{
            //    var data = bookDetails[i].Split(' ');

            //    // Ensure we trim whitespace for accurate comparison
            //    if (data[0].Trim() == bookid.Text)
            //    {
            //        //bookDetails[i] = $"{bookid.Text}, {bookName.Text}, {booktype.Text}, {booklevel.Text}";
            //        //File.WriteAllLines(bookToEdit, bookDetails);

            //        //Editmessage.Text = " book successfully edited";
            //        //Editmessage.Visible = true;
            //        //Response.Redirect("adminbook.aspx");
            //        //return;
            //    }
            //}


        }
    }
}