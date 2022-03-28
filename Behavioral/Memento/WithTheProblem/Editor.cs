using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento.WithTheProblem
{
    public class Editor
    {
        private Stack<string> _contents = new Stack<string>();       
        public void SetContent(string content)
        {
            _contents.Push(content);
        }
        public string GetContent()
        {
            return _contents.Count > 0 ? _contents.Peek() : String.Empty;
        }
        public void UndoContent()
        {
            _contents.Pop();
        }
    }
}
