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
    public class EditTodoListMapper
    {
        public virtual void Configure()
        {
            Mapper.CreateMap<EditTodoListModel, TodoList>();
        }

        public TodoList Map(EditTodoListModel model)
        {
            return Mapper.Map<EditTodoListModel, TodoList>(model);
        }
    }
}
