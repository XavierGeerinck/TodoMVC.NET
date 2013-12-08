using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Server.Models
{
    public class CreateTodoListModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(50, ErrorMessage = "Name can be maximum 50 characters long.")]
        [MinLength(3, ErrorMessage="The name given is to short.")]
        public string Name { get; set; }
    }
}
