using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.Demo2
{
    public class History
    {
        private Stack<DocumentMemento> mementos = new Stack<DocumentMemento>();
        public void Push(DocumentMemento memento)
        {
            mementos.Push(memento);
        }

        public DocumentMemento Pop()
        {
            var result = mementos.Pop();
            return mementos.Peek();
        }
    }
}
