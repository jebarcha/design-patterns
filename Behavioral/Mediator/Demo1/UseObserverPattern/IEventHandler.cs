using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.UseObserverPattern
{
    public abstract class IEventHandler //IObserver
    {
        public abstract void Handle();  // Update();
    }
}
