using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace _27_1_2025
{
    public partial class booksstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string booksFile = Server.MapPath("books.txt");
            string[] book = File.ReadAllLines(booksFile);
            foreach (string line in book)
            {
                string[] bookData = line.Split(' ');

                string rowHtml = $"<tr><td>{bookData[0]}</td><td>{bookData[1]}</td><td>{bookData[2]}</td><td>{bookData[3]}</td></tr>";
                bookstudent.InnerHtml += rowHtml;
            }
        }
    }
}