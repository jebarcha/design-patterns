using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    internal class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string FileName)
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
