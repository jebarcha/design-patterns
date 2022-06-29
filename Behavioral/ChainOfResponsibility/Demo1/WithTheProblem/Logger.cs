using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.WithTheProblem
{
    public class Logger
    {
        public void Log(HttpRequest request)
        {
            Console.WriteLine("Log");
        }
    }
}
