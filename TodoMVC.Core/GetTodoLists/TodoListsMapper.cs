using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMVC.Core.GetTodoItems;

namespace TodoMVC.Core.GetTodoList
{
    public class TodoListsMapper
    {
        public virtual void Configure() 
        {
            Mapper.CreateMap<TodoList, TodoListResult>();
            Mapper.CreateMap<TodoItem, TodoItemResult>();
        }

        public virtual TodoListResult Map(TodoList todoList)
        {
            return Mapper.Map<TodoList, TodoListResult>(todoList);
        }
    }
}
