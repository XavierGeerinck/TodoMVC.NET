using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.GetTodoList
{
    public class TodoListMapper
    {
        public virtual void Configure()
        {
            Mapper.CreateMap<TodoList, TodoListResult>();
        }

        public virtual TodoListResult Map(TodoList todoList)
        {
            return Mapper.Map<TodoList, TodoListResult>(todoList);
        }
    }
}
