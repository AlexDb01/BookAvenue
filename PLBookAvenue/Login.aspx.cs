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
        bool getLogin;
        User user;
        HttpPostedFile file; 

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(Starter.getLogin(txtUsernameLogin.Text, txtPasswordLogin.Text) == true)
            {

                Session[SessionKeys.LOGGEDIN] = txtUsernameLogin.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
                lblRegister.Text = "Login was unsuccessfull, please try again";

            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if(Starter.getRegister(txtUsernameRegister.Text, txtPasswordRegister.Text) == true)
            {
                lblRegister.Text = "Registration Successfull";
            }
            else
            {
                lblRegister.Text = "Username is already taken";
            }
        }

        
    }
}