using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator.Demo2
{
    public interface IIterator
    {
        bool HasNext();
        Product Current();
        void Next();
    }
}
