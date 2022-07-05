using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public class BrowseHistory
    {
        //private List<string> _urls = new List<string>();
        private string[] _urls = new string[10];
        private int _count = 0;

        public void Push(string url)
        {
            //_urls.Add(url);
            _urls[_count++] = url;
        }
        public string Pop()
        {
            return _urls[--_count];
            //var lastIndex = _urls.Count - 1;
            //var lastUrl = _urls[lastIndex];
            //_urls.RemoveAt(lastIndex);
            //return lastUrl;
        }
        public IIterator<string> CreateIterator()
        {
            //return new ListIterator(this);
            return new ArrayIterator(this);
        }

        public class ArrayIterator : IIterator<string>
        {
            private BrowseHistory _history;
            private int _index = 0;
            public ArrayIterator(BrowseHistory history)
            {
                _history = history;
            }

            public string Current()
            {
                return _history._urls[_index];
            }

            public bool HasNext()
            {
                return (_index < _history._count);
            }

            public void Next()
            {
                _index++;
            }
        }

        //public class ListIterator : IIterator<String>
        //{
        //    private BrowseHistory _history;
        //    private int _index;
        //    public ListIterator(BrowseHistory history)
        //    {
        //        _history = history;
        //    }
        //    public string Current()
        //    {
        //        return _history._urls[_index];
        //    }

        //    public bool HasNext()
        //    {
        //        return (_index < _history._urls.Count);
        //    }

        //    public void Next()
        //    {
        //        _index++;
        //    }
        //}
    }
 
}
