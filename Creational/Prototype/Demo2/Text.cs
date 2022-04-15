using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Demo2
{
    public class Text: IComponent
    {
        private string _content;
        public Text(string content)
        {
            _content = content;
        }

        public IComponent Clone()
        {
            return new Text(_content);
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
