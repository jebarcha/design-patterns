using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Demo2
{
    public abstract class Segment
    {
        public abstract void ApplyFilter(IAudioFilter filter);
    }
}
