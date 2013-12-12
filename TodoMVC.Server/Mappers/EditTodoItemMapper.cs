using AutoMapper;
using TodoMVC.Core;
using TodoMVC.Server.Models;

namespace TodoMVC.Server.Mappers
{
    class EditTodoItemMapper
    {
        public virtual void Configure()
        {
            Mapper.CreateMap<EditTodoItemModel, TodoItem>();
        }

        public TodoItem Map(EditTodoItemModel model)
        {
            return Mapper.Map<EditTodoItemModel, TodoItem>(model);
        }
    }
}
