using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Shape : IComponent
    {
        public void Move()
        {
            Console.WriteLine("Move Shape");
        }

        public void Render()
        {
            Console.WriteLine("Render Shape");
        }
    }
}
