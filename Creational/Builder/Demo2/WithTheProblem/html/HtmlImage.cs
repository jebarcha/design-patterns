using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Demo2.html.WithTheProblem
{
    public class HtmlImage : HtmlElement
    {
        private string source;
        public HtmlImage(string source)
        {
            this.source = source;
        }

        public override string ToString()
        {
            return $"<img src=\"{source}\" />";
        }
    }
}
