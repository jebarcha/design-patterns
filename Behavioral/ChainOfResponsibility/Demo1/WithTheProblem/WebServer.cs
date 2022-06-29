using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.WithTheProblem
{
    public class WebServer
    {
        public void Handle(HttpRequest request)
        {
            // Authentication
            var authenticator = new Authenticator();
            authenticator.Authenticate(request);
            // Logging
            // Compression..

        }
    }
}
