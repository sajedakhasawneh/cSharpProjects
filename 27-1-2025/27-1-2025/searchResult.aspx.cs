using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace _27_1_2025
{
    public partial class searchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string bookFile = Server.MapPath("books.txt");
            if (File.Exists(bookFile))
            {
                string[] readbook = File.ReadAllLines(bookFile);
                foreach (string line in readbook)
                {
                    string[] bookData = line.Split(' ');
                    if (bookData[0] == bookid1.Text)
                    {
                        bookid1.Text = bookData[0];
                        bookName.Text = bookData[1];
                        booktype.Text = bookData[2];
                        booklevel.Text = bookData[3];
                        break;

                    }
                    else
                    {
                        lable.Text = "No Book Found";
                    }
                }
            }

        }

        protected void booksearch_Click(object sender, EventArgs e)
        {
           
        }
    }
}