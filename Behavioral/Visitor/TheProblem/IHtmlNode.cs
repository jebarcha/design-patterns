using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.TheProblem
{
    public interface IHtmlNode
    {
        void Highlight();
        void PlainText();
    }
}
