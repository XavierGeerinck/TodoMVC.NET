using System.Linq;

namespace TodoMVC.Core.TodoItemHandlers
{
    public class EditTodoItemHandler
    {
        public void Handle(int id, TodoItem todoItemUpdated)
        {
            var context = new TodoContext();
            var todoItemsRepo = context.TodoItems;
            var todoItem = todoItemsRepo.Single(tl => tl.Id == id);

            // Apply updates
            todoItem.Title = todoItemUpdated.Title;
            todoItem.Description = todoItemUpdated.Description;
            todoItem.State = todoItemUpdated.State;
            todoItem.DueDate = todoItemUpdated.DueDate;
            todoItem.TodoListId = todoItemUpdated.TodoListId;
            todoItem.TodoList = todoItemUpdated.TodoList;

            // Save
            context.SaveChanges();
        }
    }
}
