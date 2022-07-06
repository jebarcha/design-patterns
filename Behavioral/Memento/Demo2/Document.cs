using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.Demo2
{
    public class Document
    {
        private string _content;
        private string _fontName;
        private int _fontSize;

        public DocumentMemento CreateMemento()
        {
            return new DocumentMemento(_content, _fontName, _fontSize);
        }

        public void Restore(DocumentMemento memento)
        {
            _content = memento.GetContent();
            _fontName = memento.GetFontName();
            _fontSize = memento.GetFontSize();
        }

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public string GetFontName()
        {
            return _fontName;
        }

        public void SetFontName(string fontName)
        {
            _fontName = fontName;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            _fontSize = fontSize;
        }

        public override string ToString()
        {
            return "Document{" +
                    "content='" + _content + '\'' +
                    ", fontName='" + _fontName + '\'' +
                    ", fontSize=" + _fontSize +
                    '}';
        }
    }
}
