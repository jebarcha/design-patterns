using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Demo2.html
{
    public class HtmlParagraph : HtmlElement
    {
        private string text;
        public HtmlParagraph(string text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return $"<p>{text}</p>";
        }
    }
}
