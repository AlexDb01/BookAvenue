using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLBookAvenue;

namespace PLBookAvenue
{
    public partial class home : System.Web.UI.Page
    {
        SqlDataAdapter sda;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(Session[SessionKeys.LOGGEDIN] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if((string)Session[SessionKeys.LOGGEDIN] == "Admin")
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }

            lblHome.Text = (string)Session[SessionKeys.LOGGEDIN];

            //alles in dieses if-Statement setzen? 
            if (!this.IsPostBack)
            {
                //alle bücher werden geladen
                sda = Starter.loadAllBooks();

                DataTable dt = new DataTable();
                sda.Fill(dt);
                gvBooks.DataSource = dt;
                //und angezeigt
                gvBooks.DataBind();

            }
        }

        //sorgt dafür, dass das Bild angezeigt wird
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["data"]);
                (e.Row.FindControl("Image1") as Image).ImageUrl = imageUrl;
            }
        }


        //User wird zur Login-Seite zurückgeführt
        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session[SessionKeys.LOGGEDIN] = null;
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }


        //Buchupload
        protected void Upload(object sender, EventArgs e)
        {
            
            //das irgendwie in den Starter oder in die Klasse book geben? vlt. in der View fehl am Platz
            byte[] bytes;

            //liest das geuploadete Bild aus
            using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                bytes = br.ReadBytes(FileUpload1.PostedFile.ContentLength);
            }

            //Buch wird hochgeladen
            Starter.uploadBook(txtTitle.Text, Convert.ToInt32(txtYear.Text), txtAuthor.Text, Convert.ToInt32(txtPages.Text), txtGenre.Text, true, FileUpload1.PostedFile.ContentType, bytes);

            //man wird wieder zurückgeführt = die Seite ladet neu
            Response.Redirect(Request.Url.AbsoluteUri);
        }


    }
}