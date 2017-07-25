using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Event
{
    public class CustomEventArgs
    {
        public CustomEventArgs(string message)
        {
            
            Message = message;
        }
        public string Message { get; private set; }

    }
}
