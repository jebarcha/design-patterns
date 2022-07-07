using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.WithTheProblem
{
    public class ListBox : UIControl
    {
        private string _selection;
        public string GetSelection() => _selection;
        public void SetSelection(string selection) => this._selection = selection;
    }
}
