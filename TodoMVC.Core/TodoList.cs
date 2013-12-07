using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core
{
    [Table("TodoList")]
    public class TodoList
    {
        public TodoList()
        {
            TodoItems = new HashSet<TodoItem>();
        }

        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        // Add reference to the todoitems
        public virtual ICollection<TodoItem> TodoItems { get; set; }
    }
}
