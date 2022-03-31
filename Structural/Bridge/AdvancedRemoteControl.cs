using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
            Console.WriteLine("AdvancedRemoteControl created");
        }

        public void SetChannel(int number)
        {
            _device.SetChannel(number);
        }
    }
}
