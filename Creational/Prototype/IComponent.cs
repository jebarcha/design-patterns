using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public interface IComponent
    {
        void Render();
        IComponent clone();  // here our component is acting like a prototype
    }
}
