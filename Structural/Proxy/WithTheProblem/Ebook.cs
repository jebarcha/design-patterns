using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.WithTheProblem
{
    public class Ebook
    {
        private string _fileName;
        public Ebook(string fileName)
        {
            _fileName = fileName;
            Load();
        }
        private void Load()
        {
            Console.WriteLine($"Loading the ebook {_fileName}");
        }
        public void Show()
        {
            Console.WriteLine($"Showing the ebook {_fileName}");
        }
        public string GetFileName() => _fileName;
    }
}
