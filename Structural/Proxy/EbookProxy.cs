using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class EbookProxy : IEbook
    {
        private string _fileName;
        private RealEbook? _ebook;
        public EbookProxy(string fileName)
        {
            _fileName = fileName;
        }

        public string GetFileName()
        {
            return _fileName;
        }

        public void Show()
        {
            if (_ebook == null)
            {
                _ebook = new RealEbook(_fileName);
            }

            _ebook.Show();
        }
    }
}
