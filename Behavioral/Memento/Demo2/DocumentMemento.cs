using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.Demo2
{
    public class DocumentMemento
    {
        private readonly string _content;
        private readonly string _fontName;
        private readonly int _fontSize;

        public DocumentMemento(string content, string fontName, int fontSize)
        {
            this._content = content;
            this._fontName = fontName;
            this._fontSize = fontSize;
        }

        public string GetContent()
        {
            return _content;
        }

        public string GetFontName()
        {
            return _fontName;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }
    }
}
