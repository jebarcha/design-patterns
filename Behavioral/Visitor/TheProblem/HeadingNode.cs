using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.TheProblem
{
    public class HeadingNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highligth-heading-withTheProblem");
        }
    }
}
