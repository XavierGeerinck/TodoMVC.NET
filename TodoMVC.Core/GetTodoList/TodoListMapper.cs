using AutoMapper;

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
