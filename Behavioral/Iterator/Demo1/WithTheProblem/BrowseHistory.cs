using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator.WithTheProblem
{
    public class BrowseHistory
    {
        private string[] _urls = new string[10];
        //private List<string> _urls = new List<string>();

        public void Push(string url)
        {
            //_urls.Add(url);
        }
        public string Pop()
        {
            //var lastIndex = _urls.Count - 1;
            //var lastUrl = _urls[lastIndex];
            //_urls.RemoveAt(lastIndex);
            //return lastUrl;
            return "";
        }
        public String[] GetUrls() => _urls;
        //public List<string> GetUrls() => _urls;
    }
}
