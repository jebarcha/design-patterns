using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.Demo2
{
    public class Button : UIControl
    {
        private bool _isEnabled;

        public bool IsEnabled()
        {
            return _isEnabled;
        }

        public void SetEnabled(bool enabled)
        {
            _isEnabled = enabled;
            NotifyEventHandlers();
        }
    }
}
