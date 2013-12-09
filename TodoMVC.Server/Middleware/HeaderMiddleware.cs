using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Server.Middleware
{
    public class HeaderMiddleware : OwinMiddleware
    {
        public HeaderMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            context.Response.Headers.Set("Access-Control-Allow-Origin", ConfigurationManager.AppSettings["ClientOrigin"]);
            context.Response.Headers.Set("Access-Control-Allow-Methods", ConfigurationManager.AppSettings["AllowedMethods"]);
            context.Response.Headers.Set("Access-Control-Allow-Headers", ConfigurationManager.AppSettings["AllowedHeaders"]);

            await this.Next.Invoke(context);
        }
    }
}
