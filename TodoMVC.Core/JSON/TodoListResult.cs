using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMVC.Core.GetTodoItems;

namespace TodoMVC.Core.GetTodoList
{
    public class TodoListResult
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<TodoItemResult> TodoItems { get; set; }
    }
}
