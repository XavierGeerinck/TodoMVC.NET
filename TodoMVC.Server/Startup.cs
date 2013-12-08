using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TodoMVC.Server.Middleware;

[assembly: OwinStartup(typeof(TodoMVC.Server.Startup))]
namespace TodoMVC.Server
{
    public class Startup
    {
        // Configure the Web API, The Startup Class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder app)
        {
            // Error code middleware, used to catch exceptions and show a debug screen, disable this in prod
            app.UseErrorPage();

            // Add cors, to enable post, put, ...
            app.UseCors(CorsOptions.AllowAll);

            // Configure Web API for self-host
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Set the Access-Control-Allow-Origin
            app.Use<HeaderMiddleware>();

            // Activate above config
            app.UseWebApi(config);
        }
    }
}
