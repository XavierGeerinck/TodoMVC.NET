using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMVC.Core;
using TodoMVC.Server.Models;

namespace TodoMVC.Server.Mappers
{
    public class CreateTodoItemMapper
    {
        public virtual void Configure()
        {
            Mapper.CreateMap<CreateTodoItemModel, TodoItem>();
        }

        public TodoItem Map(CreateTodoItemModel model)
        {
            return Mapper.Map<CreateTodoItemModel, TodoItem>(model);
        }
    }
}
