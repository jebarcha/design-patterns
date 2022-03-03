using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Highlight-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlight-anchor");
        }
    }
}
