using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace TodoMVC.Core.GetTodoList
{
    public class GetTodoListHandler
    {
        public IEnumerable<TodoListResult> Handle()
        {
            // Get connection
            var context = new TodoContext();

            // Get the todoitems
            var todoItems = context.TodoLists.Include(tt => tt.TodoItems);

            // Create the mapper to convert to JSON
            var mapper = new TodoListMapper();
            mapper.Configure();

            return todoItems.Select(mapper.Map);
        }
    }
}
