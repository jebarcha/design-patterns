using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Slide
    {
        private string _text;
        public string Text { get => _text; }
        public Slide(string text)
        {
            _text = text;
        }

    }
}
