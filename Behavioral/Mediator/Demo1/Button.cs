using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class Button : UIControl
    {
        private bool _isEnabled;
        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnabled() => _isEnabled;
        public void SetEnabled(bool enabled)
        {
            _isEnabled = enabled;
            _owner.Changed(this);
        }
    }
}
