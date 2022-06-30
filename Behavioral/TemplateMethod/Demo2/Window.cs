using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod.Demo2
{
    public class Window
    {
        // The close method is defining a template. Custom window classes
        // can use this template and determine what should happen before and
        // after a window is closed.
        public void close()
        {
            OnClosing();

            Console.WriteLine("Removing the window from the screen");

            OnClosed();
        }

        protected virtual void OnClosing() { }
        protected virtual void OnClosed() { }
    }
}
