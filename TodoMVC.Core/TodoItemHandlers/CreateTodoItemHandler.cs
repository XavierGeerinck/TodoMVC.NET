using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.TodoItemHandlers
{
    public class CreateTodoItemHandler
    {
        public void Handle(TodoItem todoItem)
        {
            var context = new TodoContext();
            var todoItemsRepo = context.TodoItems;
            todoItemsRepo.Add(todoItem);
            context.SaveChanges();
        }
    }
}
