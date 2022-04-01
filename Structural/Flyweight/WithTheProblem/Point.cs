using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.WithTheProblem
{
    public class Point
    {
        private int _x;  // 4 bytes
        private int _y;  // 4 bytes
        private EnumPointType _type;  // 4 bytes
        private byte[] _icon;  // 20 KB -> 20 MB
        public Point(int x, int y, EnumPointType type, byte[] icon)
        {
            _x = x;
            _y = y;
            _type = type;
            _icon = icon;
        }
        public void Draw()
        {
            Console.WriteLine($"{_type} at ({_x},{_y})");
        }
    }
}
