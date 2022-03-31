using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AntWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new AntButton();
        }

        public ITextBox CreateTextBox()
        {
            return new AntTextBox();
        }
    }
}
