using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMVC.Core.JSON;

namespace TodoMVC.Core.Mappers
{
    public class TodoListMapper
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
