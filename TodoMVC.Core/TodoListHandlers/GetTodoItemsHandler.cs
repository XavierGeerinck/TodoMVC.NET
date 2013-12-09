using System.Collections.Generic;
using System.Linq;
using TodoMVC.Core.JSON;
using TodoMVC.Core.Mappers;

namespace TodoMVC.Core.TodoListHandlers
{
    public class GetTodoItemsHandler
    {
        public IEnumerable<TodoItemResult> Handle()
        {
            // Get the todoitems
            var todoItems = new TodoContext().TodoItems;

            // Map all the items to the json objects
            var mapper = new TodoItemMapper();
            mapper.Configure();

            return todoItems.Select(mapper.Map);
        }
    }
}
