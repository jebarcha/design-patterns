using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            IComponent newComponent = component.clone();
            newComponent.Render();
        }
    }
}
