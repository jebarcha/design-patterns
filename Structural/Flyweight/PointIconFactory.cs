using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight
{
    public class PointIconFactory
    {
        private Dictionary<EnumPointType, PointIcon> _icons = new Dictionary<EnumPointType, PointIcon>();
        public PointIcon GetPointIcon(EnumPointType type)
        {
            if (!_icons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                _icons.Add(type, icon);
            }

            return _icons[type];
        }
    }
}
