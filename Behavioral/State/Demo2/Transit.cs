using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State.Demo2
{
    public class Transit : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }
    }
}
