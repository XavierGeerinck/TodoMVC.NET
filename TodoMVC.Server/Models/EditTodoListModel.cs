using System.ComponentModel.DataAnnotations;

namespace TodoMVC.Server.Models
{
    public class EditTodoListModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(50, ErrorMessage = "Name can be maximum 50 characters long.")]
        [MinLength(3, ErrorMessage = "The name given is to short.")]
        public string Name { get; set; }
    }
}
