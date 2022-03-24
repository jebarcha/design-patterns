using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    // This approach is not as flexible as using composition
    // Best practices: favor composition over inheritance
    public class CaramelFilterAdapterInheriting : Caramel, IFilter
    {
        public void Apply(Image image)
        {
            this.Init();
            Render(image);
        }
    }
}
