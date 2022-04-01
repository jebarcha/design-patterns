using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class PointIcon
    {
        private readonly EnumPointType _type;  // 4 bytes
        private readonly byte[] _icon;  // 20 KB -> 20 MB
        public PointIcon(EnumPointType type, byte[] icon)
        {
            _type = type;
            _icon = icon;
        }
        public EnumPointType GetPointType() => _type;
    }
}
