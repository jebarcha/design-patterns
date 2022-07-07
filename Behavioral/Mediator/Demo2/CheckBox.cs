using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Demo2
{
    public class CheckBox : UIControl
    {
        private bool _isChecked;

        public bool IsChecked()
        {
            return _isChecked;
        }

        public void SetChecked(bool isChecked)
        {
            _isChecked = isChecked;
            NotifyEventHandlers();
        }
    }
}
