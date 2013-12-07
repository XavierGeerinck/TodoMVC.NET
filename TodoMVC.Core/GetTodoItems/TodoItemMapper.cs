using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.GetTodoItems
{
    public class TodoItemMapper
    {
        public virtual void Configure()
        {
            Mapper.CreateMap<TodoItem, TodoItemResult>();
        }

        public virtual TodoItemResult Map(TodoItem todoItem)
        {
            return Mapper.Map<TodoItem, TodoItemResult>(todoItem);
        }
    }
}
