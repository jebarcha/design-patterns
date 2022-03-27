using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.WithTheProblem
{
    public class Authenticator
    {
        public bool Authenticate(HttpRequest request)
        {
            var isValid = (request.Username == "admin") && (request.Password == "123456");
            Console.WriteLine("Authentication");
            return isValid;
        }
    }
}
