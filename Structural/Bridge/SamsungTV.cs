using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class SamsungTV : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine($"Samsung: SetChannel {number}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung: TurnOff");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung: TurnOn");
        }
    }
}
