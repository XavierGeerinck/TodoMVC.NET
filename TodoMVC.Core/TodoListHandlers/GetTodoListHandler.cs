using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using TodoMVC.Core.JSON;
using TodoMVC.Core.Mappers;

namespace TodoMVC.Core.TodoListHandlers
{
    public class GetTodoListHandler
    {
        public TodoListResult Handle(int id)
        {
            // Get connection
            var context = new TodoContext();

            // Get the todoitems
            var todoList = context.TodoLists.Include(tt => tt.TodoItems).Single(tl => tl.Id == id);

            // Create the mapper to convert to JSON
            var mapper = new TodoListMapper();
            mapper.Configure();

            var result = mapper.Map(todoList);

            return result;
        }
    }
}
