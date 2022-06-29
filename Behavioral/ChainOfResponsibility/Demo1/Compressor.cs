using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compress");
            return false;
        }
    }
}
