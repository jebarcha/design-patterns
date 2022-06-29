using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Demo2.WithTheProblem
{
    public class Text : Element
    {
        private string content;
        public Text(string content)
        {
            this.content = content;
        }
        public string GetContent()
        {
            return content;
        }
    }
}
