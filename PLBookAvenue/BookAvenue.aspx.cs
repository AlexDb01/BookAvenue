using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLBookAvenue;

namespace PLBookAvenue
{
    public partial class BookAvenue : System.Web.UI.Page
    {
        Book book;
        protected void Page_Load(object sender, EventArgs e)
        {
            book = Starter.getBookById(1);
            lblTitle.Text = book.title + " " + book.author + " " + book.year + " " + book.type + " " + book.availability; 

        }

        protected void registered(string username, string password)
        {
            if(Starter.getRegister(username, password) == true)
            {
                MultiView1.ActiveViewIndex = 2;
            } else
            {
                MultiView1.ActiveViewIndex = 1;
            }
        }


        protected void login(string username, string password)
        {
            if (Starter.getLogin(username, password) == true)
            {
                MultiView1.ActiveViewIndex = 2;
            }
            else
            {
                MultiView1.ActiveViewIndex = 1;
            }
        }
    }
}