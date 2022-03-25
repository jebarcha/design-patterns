using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Group : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void Move()
        {
            foreach (IComponent component in components)
            {
                component.Move();
            }
        }

        public void Render()
        {
            foreach (var component in components)
            {
                component.Render();
            }
        }
    }
}
