using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.WithTheProblem
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            if (component is Circle)
            {   // logic for copying/cloning our circle:
                Circle source = (Circle)component;
                Circle target = new Circle();
                target.Radious = source.Radious;
                // Add target to our document (no worry about this now)

            }
        }
    }
}
