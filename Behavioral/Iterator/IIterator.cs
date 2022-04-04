using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}
