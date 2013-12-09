using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TodoMVC.Core;
using TodoMVC.Core.JSON;
using TodoMVC.Core.Mappers;
using TodoMVC.Core.TodoListHandlers;
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

        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var getTodoListHandler = new GetTodoListHandler();
            var result = getTodoListHandler.Handle(id);

            var response = Request.CreateResponse<TodoListResult>(HttpStatusCode.OK, result);
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

                // Map the todoList to the todoList result
                var mapperResult = new TodoListMapper();
                mapperResult.Configure();
                var todoListResult = mapperResult.Map(todoList);

                // Return the todoListResult
                var response = Request.CreateResponse<TodoListResult>(HttpStatusCode.Created, todoListResult);
                return response;
            }

            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ModelState);
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var deleteTodoListHandler = new DeleteTodoListHandler();
            deleteTodoListHandler.Handle(id);

            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        [HttpPut]
        public HttpResponseMessage Put(int id, EditTodoListModel model)
        {
            if (ModelState.IsValid)
            {
                // Bind the model to a TodoList object
                var mapper = new EditTodoListMapper();
                mapper.Configure();

                // Map the model to the todolist result
                var todoList = mapper.Map(model);

                // Create the todoList
                var editTodoListHandler = new EditTodoListHandler();
                editTodoListHandler.Handle(id, todoList);

                var response = Request.CreateResponse<TodoList>(HttpStatusCode.OK, todoList);
                return response;
            }

            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ModelState);
        }
    }
}
