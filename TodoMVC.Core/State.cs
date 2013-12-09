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
        ToDo       = 0x00,
        [Description("InProgress")]
        InProgress = 0x01,
        [Description("Completed")]
        Completed  = 0x02
    }
}
