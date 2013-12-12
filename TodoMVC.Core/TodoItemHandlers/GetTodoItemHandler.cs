using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMVC.Core.JSON;

namespace TodoMVC.Core.TodoItemHandlers
{
    public class GetTodoItemHandler
    {
        public TodoItem Handle(int id)
        {
            var context = new TodoContext();
            var repo = context.TodoItems;
            var todoItem = repo.Single(ti => ti.Id == id);

            return todoItem;
        }
    }
}
