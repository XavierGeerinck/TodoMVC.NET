using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.DeleteTodoList
{
    public class DeleteTodoListHandler
    {
        public void Handle(int todoListId)
        {
            var context = new TodoContext();
            var todoListsRepo = context.TodoLists;
            var todoList = todoListsRepo.Single(tl => tl.Id == todoListId);
            
            todoListsRepo.Remove(todoList);
            context.SaveChanges();
        }
    }
}
