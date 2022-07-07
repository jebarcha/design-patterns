using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class DialogBox
    {
        public abstract void Changed(UIControl control);
    }
}
