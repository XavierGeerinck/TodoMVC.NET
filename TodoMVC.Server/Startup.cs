using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TodoMVC.Server
{
    public class Startup
    {
        // Configure the Web API, The Startup Class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Set the Access-Control-Allow-Origin
            //appBuilder.Use();
            //appBuilder.MapHubs(new HubConfiguration { EnableCrossDomain = true });
            //listener.Headers.Set("Access-Control-Allow-Origin", "http://http://127.0.0.1:56759/");

            // Activate above config
            appBuilder.UseWebApi(config);
        }
    }
}
