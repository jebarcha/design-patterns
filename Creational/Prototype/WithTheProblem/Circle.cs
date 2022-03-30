using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.WithTheProblem
{
    public class Circle : IComponent
    {
        private int _radious;
        public int Radious { get => _radious; set => _radious = value; }
        public void Render()
        {
            Console.WriteLine("Rendering a circle");
        }
    }
}
