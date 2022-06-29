using DesignPatterns.Creational.Builder.Demo2.html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Demo2.WithTheProblem
{
    public class Document
    {
        private List<Element> elements = new List<Element>();
        public void Add(Element element)
        {
            elements.Add(element);
        }

        public void Export(ExportFormat format, string fileName)
        {
            string content = "";

            if (format == ExportFormat.HTML)
            {
                var document = new HtmlDocument();

                foreach (var element in elements)
                {
                    if (element is Text)
                    {
                        var text = ((Text)element).GetContent();
                        document.Add(new HtmlParagraph(text));
                    }
                    else if (element is Image)
                    {
                        var source = ((Image)element).GetSource();
                        document.Add(new HtmlImage(source));
                    }
                }

                content = document.ToString();
            }
            else if (format == ExportFormat.TEXT)
            {
                var builder = new StringBuilder();

                foreach (var element in elements)
                {
                    if (element is Text)
                    {
                        var text = ((Text)element).GetContent();
                        builder.Append(text);
                    }
                }

                content = builder.ToString();
            }

            //StreamWriter writer = File.CreateText(fileName);
            //writer.Write(content);
            //writer.Close();
            Console.WriteLine(content);
        }
    }
}
