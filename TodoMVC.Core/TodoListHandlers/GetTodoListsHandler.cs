using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using TodoMVC.Core.JSON;
using TodoMVC.Core.Mappers;

namespace TodoMVC.Core.TodoListHandlers
{
    public class GetTodoListsHandler
    {
        public IEnumerable<TodoListResult> Handle()
        {
            // Get connection
            var context = new TodoContext();

            // Get the todoitems
            var todoLists = context.TodoLists.Include(tt => tt.TodoItems);

            // Create the mapper to convert to JSON
            var mapper = new TodoListMapper();
            mapper.Configure();

            var result = todoLists.Select(mapper.Map);

            return result;
        }
    }
}
