using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Button
    {
        private string _label;
        private ICommand _command;
        public Button(ICommand command)
        {
            _command = command;
        }

        public void Click()
        {
            // ... the code here is dependent of where we using this button
            _command.Execute(); // delegating the work to the command object
        }
        public string GetLabel() { return _label; }
        public void SetLabel(string label) { this._label = label; }
    }
}
