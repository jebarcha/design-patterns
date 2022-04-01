using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.WithTheProblem
{
    public class PointService
    {
        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, EnumPointType.CAFE, null);
            points.Add(point);

            return points;
        }

    }
}
