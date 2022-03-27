using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler next;
        public Handler(Handler next)
        {
            this.next = next;
        }
        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            if (next != null)
            {
                next.Handle(request);
            }
        }
        public abstract bool DoHandle(HttpRequest request);
        
    }
}
