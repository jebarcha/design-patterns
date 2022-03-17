using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Example3_UndoableOperations
{
    public interface IUndoableCommand : ICommand
    {
        void UnExecute();
    }
}
