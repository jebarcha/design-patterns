using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Text-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Text-anchor");
        }
    }
}
