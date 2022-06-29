using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Demo2
{
    public class FormatSegment : Segment
    {
        public override void ApplyFilter(IAudioFilter filter)
        {
            filter.Apply(this);
        }
    }
}
