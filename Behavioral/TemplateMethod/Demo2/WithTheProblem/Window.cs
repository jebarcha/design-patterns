using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod.Demo2.WithTheProblem
{
    public class Window
    {
        public void Close()
        {
            //TODO: custom windows may need to execute some code before the window
            // is closed.

            Console.WriteLine("Removing the window from the screen");

            //TODO: custom windows may need to execute some code after the window
            // is closed.
        }
    }
}
