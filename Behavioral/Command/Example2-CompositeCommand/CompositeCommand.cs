using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command.Example2
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> _commands = new List<ICommand>();
        public void Add(ICommand command)
        {
            _commands.Add(command);
        }
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
