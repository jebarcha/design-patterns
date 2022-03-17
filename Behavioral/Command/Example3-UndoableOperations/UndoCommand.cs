using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Example3_UndoableOperations
{
    public class UndoCommand : ICommand
    {
        private History _history;
        public UndoCommand(History history)
        {
            _history = history;
        }

        public void Execute()
        {
            if (_history.Size() > 0)
            {
                _history.Pop().UnExecute();
            }
        }
    }
}
