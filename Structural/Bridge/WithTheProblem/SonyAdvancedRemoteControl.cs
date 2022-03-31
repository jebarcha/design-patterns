using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.WithTheProblem
{
    public class SonyAdvancedRemoteControl : AdvancedRemoteControl
    {
        public override void SetChannel(int number)
        {
            Console.WriteLine("Sony: setChannel");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Sony: TurnOff");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony: TurnOn");
        }
    }
}
