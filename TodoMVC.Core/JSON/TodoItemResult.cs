using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMVC.Core.JSON
{
    public class TodoItemResult
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public State State { get; set; }
        public DateTime DueDate { get; set; }
    }
}
