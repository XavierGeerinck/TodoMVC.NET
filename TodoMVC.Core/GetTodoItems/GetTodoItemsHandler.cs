using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.GetTodoItems
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
