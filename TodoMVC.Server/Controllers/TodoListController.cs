using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TodoMVC.Core;
using TodoMVC.Core.CreateTodoList;
using TodoMVC.Core.GetTodoList;
using TodoMVC.Core.GetTodoLists;
using TodoMVC.Server.Mappers;
using TodoMVC.Server.Models;

namespace TodoMVC.Server.Controllers
{
    public class TodoListController : ApiController
    {
        public string Options()
        {
            return null;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            var getTodoListsHandler = new GetTodoListsHandler();
            var result = getTodoListsHandler.Handle();

            var response = Request.CreateResponse<IEnumerable<TodoListResult>>(HttpStatusCode.OK, result);
            return response;
        }

        [HttpPost]
        public HttpResponseMessage Post(CreateTodoListModel model)
        {
            if (ModelState.IsValid)
            {
                // Bind the model to a TodoList object
                var mapper = new CreateTodoListMapper();
                mapper.Configure();

                var todoList = mapper.Map(model);

                // Create the todoList
                var createTodoListHandler = new CreateTodoListHandler();
                createTodoListHandler.Handle(todoList);

                var response = Request.CreateResponse<TodoList>(HttpStatusCode.Created, todoList);
                return response;
            }

            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ModelState);
        }
    }
}
