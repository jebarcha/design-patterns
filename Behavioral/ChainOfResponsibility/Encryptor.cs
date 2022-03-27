using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Encryptor : Handler
    {
        public Encryptor(Handler next) : base(next)
        {
        }
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Encryption");
            return false;
        }
    }
}
