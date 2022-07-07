using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Demo2
{
    public class UIControl
    {
        private List<IEventHandler> _eventHandlers = new List<IEventHandler>();

        public void AddEventHandler(IEventHandler handler)
        {
            _eventHandlers.Add(handler);
        }

        public void NotifyEventHandlers()
        {
            foreach (IEventHandler handler in _eventHandlers)
            {
                handler.Handle();
            }
        }
    }
}
