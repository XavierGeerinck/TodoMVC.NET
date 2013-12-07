using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TodoMVC.Core;
using TodoMVC.Core.GetTodoList;

namespace TodoMVC.Server.Controllers
{
    public class TodoListController : ApiController
    {
        public IEnumerable<TodoListResult> Get()
        {
            var getTodoListHandler = new GetTodoListHandler();
            var result = getTodoListHandler.Handle();

            return result;
        }
    }
}
