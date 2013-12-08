using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TodoMVC.Core.GetTodoItems;

namespace TodoMVC.Server.Controllers
{
    public class TodoItemController : ApiController
    {
        public IEnumerable<TodoItemResult> Get()
        {
            var getTodoItemsHandler = new GetTodoItemsHandler();
            var result = getTodoItemsHandler.Handle();

            return result;
        }
    }
}
