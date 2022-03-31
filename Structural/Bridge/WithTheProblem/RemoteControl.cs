using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.WithTheProblem
{
    // RemoteControl
    //   SonyRemoteControl
    //   SamsungRemoteControl
    //   AdvancedRemoteControl
    //     SonyAdvancedRemoteControl
    //     SamsungAdvancedRemoteControl
    //
    // everytime we need to support a new remote control, we need to create 2 new classes

    // Basic Remote Control (turnOn, turnOff)
    // Advance Remote Control (setChannel)
    // Movie Remote Control (play, pause, rewind)
    public abstract class RemoteControl
    {
        public abstract void TurnOn();
        public abstract void TurnOff();

    }
}
