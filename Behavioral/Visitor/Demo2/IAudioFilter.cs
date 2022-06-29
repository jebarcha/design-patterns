using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor.Demo2
{
    public interface IAudioFilter
    {
        void Apply(FormatSegment formatSegment);
        void Apply(FactSegment factSegment);
    }
}
