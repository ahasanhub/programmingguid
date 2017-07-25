using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG.Event
{
    public class Publisher
    {
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void Dosomething()
        {
            OnRaiseCustomEvent(new CustomEventArgs("Did something"));
        }

        private void OnRaiseCustomEvent(CustomEventArgs customEventArgs)
        {
            RaiseCustomEvent?.Invoke(this,customEventArgs);
        }
    }
}
