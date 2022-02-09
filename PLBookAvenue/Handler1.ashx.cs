using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PLBookAvenue
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        DefaultHttpHandler cls = new DefaultHttpHandler();
        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            //string displayImgId = context.Request.QueryString["id_image"].ToString();
            //cls.connection();
            

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}