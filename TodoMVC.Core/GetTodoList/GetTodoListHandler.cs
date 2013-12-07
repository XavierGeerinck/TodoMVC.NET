using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.GetTodoList
{
    public class GetTodoListHandler
    {
        public IEnumerable<TodoListResult> Handle()
        {
            // Get the todoitems
            var todoItems = new TodoContext().TodoLists;

            // Create the mapper to convert to JSON
            var mapper = new TodoListMapper();
            mapper.Configure();

            return todoItems.Select(mapper.Map);
        }
    }
}
