using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");
            return false;
        }
    }
}
