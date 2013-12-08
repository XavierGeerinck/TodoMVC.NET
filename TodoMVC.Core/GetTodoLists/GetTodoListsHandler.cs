using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using TodoMVC.Core.GetTodoList;

namespace TodoMVC.Core.GetTodoLists
{
    public class GetTodoListsHandler
    {
        public IEnumerable<TodoListResult> Handle()
        {
            // Get connection
            var context = new TodoContext();

            // Get the todoitems
            var todoItems = context.TodoLists.Include(tt => tt.TodoItems);

            // Create the mapper to convert to JSON
            var mapper = new TodoListsMapper();
            mapper.Configure();

            var result = todoItems.Select(mapper.Map);

            return result;
        }
    }
}
