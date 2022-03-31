using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class Library
    {
        private Dictionary<string, IEbook> _ebooks = new Dictionary<string, IEbook>();
        public void Add(IEbook ebook)
        {
            _ebooks.Add(ebook.GetFileName(), ebook);
        }
        public void OpenEbook(string fileName)
        {
            _ebooks[fileName].Show();
        }
    }
}
