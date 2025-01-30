using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class bookSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void search_Click(object sender, EventArgs e)
        {
            //Response.Redirect("searchResult.aspx");
            string bookFile = Server.MapPath("books.txt");
            if (File.Exists(bookFile))
            {
                string[] readbook = File.ReadAllLines(bookFile);
                foreach (string line in readbook)
                {
                    string[] bookData = line.Split(' ');
                    if (bookData[0] == booksearch.Text)
                    {
                        //bookid1.Text = bookData[0];
                        bookName.Text = bookData[1];
                        booktype.Text = bookData[2];
                        booklevel.Text = bookData[3];
                        break;

                    }
                    else
                    {
                        datalable.Text = "No Book Found";
                        Visible = true;
                        bookName.Text ="";
                        booktype.Text = "";
                        booklevel.Text = "";

                    }
                }
            }

        }

    }
}