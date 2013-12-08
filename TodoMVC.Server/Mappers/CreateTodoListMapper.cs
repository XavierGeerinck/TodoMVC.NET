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
    public class CreateTodoListMapper
    {
        public virtual void Configure()
        {
            Mapper.CreateMap<CreateTodoListModel, TodoList>();
        }

        public TodoList Map(CreateTodoListModel model)
        {
            return Mapper.Map<CreateTodoListModel, TodoList>(model);
        }
    }
}
