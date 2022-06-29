using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Demo2
{
    public class TextDocumentBuilder : DocumentBuilder
    {
        private StringBuilder builder = new StringBuilder();
        public void AddImage(Image image)
        {
            // Note that this method has no implementation because
            // images cannot be added to a plain text file.
        }

        public void AddText(Text text)
        {
            builder.Append(text.GetContent());
        }

        public string GetResult()
        {
            return builder.ToString();
        }
    }
}
