using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Demo2
{
    public class Timeline
    {
        private List<IComponent> _components = new List<IComponent>();
        public void Add(IComponent component)
        {
            _components.Add(component);
        }
        
    }
}
