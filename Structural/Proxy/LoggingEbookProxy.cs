using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class LoggingEbookProxy : IEbook
    {
        private string _fileName;
        private RealEbook _ebook;
        public LoggingEbookProxy(string fileName)
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

            Console.WriteLine("Logging");
            _ebook.Show();
        }
    }
}
