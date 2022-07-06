using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Demo2
{
    public interface ITravelMode
    {
        Object GetEta();
        Object GetDirection();
    }
}
