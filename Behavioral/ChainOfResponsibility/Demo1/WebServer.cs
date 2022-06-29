using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class WebServer
    {
        // Maintain a reference to the first handler in the chain
        private Handler _handler;
        public WebServer(Handler handler)
        {
            if (handler != null)
            {
                _handler = handler;
            }
        }

        public void Handle(HttpRequest request)
        {
            // Authentication
            // Logging
            // Compression..

            _handler.Handle(request);

        }
    }
}
