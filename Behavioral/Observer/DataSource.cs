using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class DataSource : Subject
    {
        private int _value;
        public int GetValue() => _value;
        public void SetValue(int value)
        {
            _value = value;
            NotifyObservers();
        }
    }
}
