using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.TodoItemHandlers
{
    public class DeleteTodoItemHandler
    {
        public void Handle(int todoItemId)
        {
            var context = new TodoContext();
            var todoItemRepo = context.TodoItems;
            var todoItem = todoItemRepo.Single(ti => ti.Id == todoItemId);

            todoItemRepo.Remove(todoItem);
            context.SaveChanges();
        }
    }
}
