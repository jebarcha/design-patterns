using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Example3_UndoableOperations
{
    public class History
    {
        private Queue<IUndoableCommand> _commands = new Queue<IUndoableCommand>();
        public void Push(IUndoableCommand command)
        {
            _commands.Enqueue(command);
        }
        public IUndoableCommand Pop()
        {
            return _commands.Dequeue();
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}
