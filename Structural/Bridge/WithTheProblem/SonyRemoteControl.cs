using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.WithTheProblem
{
    public class SonyRemoteControl : RemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Sony: TurnOn");
        }
        public override void TurnOff()
        {
            Console.WriteLine("Sony: TurnOff");
        }
    }
}
