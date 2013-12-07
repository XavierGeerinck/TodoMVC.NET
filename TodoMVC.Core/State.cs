using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TodoMVC.Core
{
    public enum State
    {
        [Description("ToDo")]
        ToDo,
        [Description("InProgress")]
        InProgress,
        [Description("Completed")]
        Completed
    }
}
