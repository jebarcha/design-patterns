using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.TheProblem
{
    public class AnchorNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highlight-anchor-withTheProblem");
        }

        public void PlainText()
        {
            Console.WriteLine("PlainText-anchor-withTheProblem");
        }
    }
}
