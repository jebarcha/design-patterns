using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MaterialWidgetFactory : IWidgetFactory
    {
        public IButton CreateButton()
        {
            return new MaterialButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MaterialTextBox();
        }
    }
}
