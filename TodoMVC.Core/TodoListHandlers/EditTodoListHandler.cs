using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.TodoListHandlers
{
    public class EditTodoListHandler
    {
        public void Handle(int id, TodoList todoListUpdated)
        {
            var context = new TodoContext();
            var todoListsRepo = context.TodoLists;
            var todoList = todoListsRepo.Single(tl => tl.Id == id);

            // Apply updates
            todoList.Name = todoListUpdated.Name;

            // Save
            context.SaveChanges();
        }
    }
}
