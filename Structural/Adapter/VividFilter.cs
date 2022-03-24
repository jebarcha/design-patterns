using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Apply Vivid Filter");
        }
    }
}
