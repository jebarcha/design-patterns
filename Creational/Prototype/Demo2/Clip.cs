using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Demo2
{
    public class Clip : IComponent
    {
        public IComponent Clone()
        {
            return new Clip();
        }
    }
}
