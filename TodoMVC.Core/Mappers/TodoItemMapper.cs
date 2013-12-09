using AutoMapper;
using TodoMVC.Core.JSON;

namespace TodoMVC.Core.Mappers
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
