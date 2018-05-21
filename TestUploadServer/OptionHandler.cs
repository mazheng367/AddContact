using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUploadServer
{
    public class OptionHandler:IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public bool IsReusable
        {
            get { return true; }
        }
    }
}