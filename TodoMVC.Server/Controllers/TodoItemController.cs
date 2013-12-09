using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TodoMVC.Core.JSON;
using TodoMVC.Core.Mappers;
using TodoMVC.Core.TodoItemHandlers;
using TodoMVC.Core.TodoListHandlers;
using TodoMVC.Server.Mappers;
using TodoMVC.Server.Models;

namespace TodoMVC.Server.Controllers
{
    public class TodoItemController : ApiController
    {
        public string Options()
        {
            return null;
        }

        [HttpGet]
        public HttpResponseMessage Get()
        {
            var getTodoItemsHandler = new GetTodoItemsHandler();
            var result = getTodoItemsHandler.Handle();

            var response = Request.CreateResponse<IEnumerable<TodoItemResult>>(HttpStatusCode.OK, result);
            return response;
        }

        [HttpPost]
        public HttpResponseMessage Post(CreateTodoItemModel model)
        {
            if (ModelState.IsValid)
            {
                // Map the model
                var mapper = new CreateTodoItemMapper();
                mapper.Configure();
                var todoItem = mapper.Map(model);

                // Create the item
                var createTodoItemHandler = new CreateTodoItemHandler();
                createTodoItemHandler.Handle(todoItem);

                // Map the item to the json
                var mapperResult = new TodoItemMapper();
                mapperResult.Configure();
                var todoItemResult = mapperResult.Map(todoItem);

                // Return the response
                var response = Request.CreateResponse<TodoItemResult>(HttpStatusCode.Created, todoItemResult);
                return response;
            }

            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ModelState);
        }
    }
}
