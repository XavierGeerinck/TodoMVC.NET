using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMVC.Core._Extensions;

namespace TodoMVC.Core.StateHandlers
{
    public class GetStatesHandler
    {
        public IDictionary<int, string> Handle()
        {
            var states = EnumExtensions.ToDictionary(typeof(State));
            return states;
        }
    }
}
