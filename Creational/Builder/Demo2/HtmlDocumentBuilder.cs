using DesignPatterns.Creational.Builder.Demo2.html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Demo2
{
    public class HtmlDocumentBuilder : DocumentBuilder
    {
        private HtmlDocument document = new HtmlDocument();
        public void AddImage(Image image)
        {
            document.Add(new HtmlImage(image.GetSource()));
        }

        public void AddText(Text text)
        {
            document.Add(new HtmlParagraph(text.GetContent()));
        }

        public string GetResult()
        {
            return document.ToString();
        }
    }
}
