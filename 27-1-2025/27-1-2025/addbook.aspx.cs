using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class addbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addbook_Click(object sender, EventArgs e)
        {
            string bookFile = Server.MapPath("books.txt");
            if (!File.Exists(bookFile))
            {
                using (StreamWriter writeBook = File.CreateText(bookFile))
                {
                    writeBook.WriteLine($"{bookid.Text} {bookName.Text} {booktype.Text} {booklevel.Text}");
                }

            }

            else
            {
                using (StreamWriter writeBook2 = new StreamWriter(bookFile, true))
                {
                    writeBook2 .WriteLine($"{bookid.Text} {bookName.Text} {booktype.Text} {booklevel.Text}");
                }

            }
        }
    }
}