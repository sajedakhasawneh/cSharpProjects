﻿using System;
using System.Collections.Generic;
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
            Response.Redirect("editBook.aspx");

        }
    }
}