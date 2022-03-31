using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.WithTheProblem
{
    public class Library
    {
        private Dictionary<string, Ebook> _ebooks = new Dictionary<string, Ebook>();
        public void Add(Ebook ebook)
        {
            _ebooks.Add(ebook.GetFileName(), ebook);
        }
        public void OpenEbook(string fileName)
        {
            _ebooks[fileName].Show();
        }
    }
}
