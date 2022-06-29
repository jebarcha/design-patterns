using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.Username == "admin") && (request.Password == "123456");
            Console.WriteLine("Authentication");
            return !isValid;
        }
        
    }
}
