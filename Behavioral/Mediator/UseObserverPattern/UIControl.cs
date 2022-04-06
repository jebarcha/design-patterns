using DesignPatterns.Behavioral.Mediator.UseObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.UseObserverPattern
{
    public abstract class UIControl
    {
        private List<IEventHandler> _eventHandlers = new List<IEventHandler>();
        public void AddEventHandler(IEventHandler observer)
        {
            _eventHandlers.Add(observer);
        }
        protected void NotifyEventHandlers() //NotifyObservers()
        {
            foreach (var observer in _eventHandlers)
            {
                observer.Handle();
            }
        }
    }
}
