using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.TodoListHandlers
{
    public class CreateTodoListHandler
    {
        public void Handle(TodoList todoList)
        {
            var context = new TodoContext();
            var todoListsRepo = context.TodoLists;

            todoListsRepo.Add(todoList);
            context.SaveChanges();
        }
    }
}
