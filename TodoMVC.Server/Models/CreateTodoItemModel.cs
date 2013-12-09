using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMVC.Core;

namespace TodoMVC.Server.Models
{
    public class CreateTodoItemModel
    {
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(50, ErrorMessage = "Title can be maximum 50 characters long.")]
        [MinLength(3, ErrorMessage = "The title given is to short.")]
        public String Title { get; set; }
        public String Description { get; set; }

        [Required(ErrorMessage = "The state is required.")]
        public State State { get; set; }

        [Required(ErrorMessage = "DueDate is required.")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "TodoList is required.")]
        public virtual int? TodoListId { get; set; }
    }
}
