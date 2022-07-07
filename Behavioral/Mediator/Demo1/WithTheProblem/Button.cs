using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator.WithTheProblem
{
    public class Button : UIControl
    {
        private bool _isEnabled;
        public void SetEnabled(bool enabled) => _isEnabled = enabled;
        public bool IsEnabled() => _isEnabled;
    }
}
