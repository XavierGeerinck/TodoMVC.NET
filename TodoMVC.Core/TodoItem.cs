using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core
{
    [Table("TodoItem")]
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public State State { get; set; }
        public DateTime DueDate { get; set; }
    }
}
