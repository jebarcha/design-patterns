using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class CaramelFilterAdapter : IFilter
    {
        private Caramel _caramel;
        public CaramelFilterAdapter(Caramel caramel)
        {
            this._caramel = caramel;
        }

        public void Apply(Image image)
        {
            this._caramel.Init();
            _caramel.Render(image);
        }
    }
}
