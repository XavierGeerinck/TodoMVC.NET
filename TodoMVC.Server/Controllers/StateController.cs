using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TodoMVC.Core;
using TodoMVC.Core.StateHandlers;

namespace TodoMVC.Server.Controllers
{
    public class StateController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var statesHandler = new GetStatesHandler();
            var states = statesHandler.Handle();
            var response = Request.CreateResponse<IDictionary<int, string>>(HttpStatusCode.OK, states);
            return response;
        }
    }
}
