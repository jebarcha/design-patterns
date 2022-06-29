using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Demo2.WithTheProblem
{
    public class Image : Element
    {
        private string source;
        public Image(string source)
        {
            this.source = source;
        }
        public string GetSource()
        {
            return source;
        }
    }
}
