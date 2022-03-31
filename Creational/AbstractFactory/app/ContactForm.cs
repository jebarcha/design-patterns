using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.app
{
    public class ContactForm
    {
        public void Render(IWidgetFactory factory)
        {
            factory.CreateTextBox().Render();
            factory.CreateButton().Render();
        }

        //public void Render(EnumTheme theme)
        //{
            // With the Problem:
            //if (theme == EnumTheme.ANT)
            //{
            //    new AntTextBox().Render();
            //    new AntButton().Render();
            //}
            //else if (theme == EnumTheme.MATERIAL)
            //{
            //    new MaterialTextBox().Render();
            //    new MaterialButton().Render();
            //}
        //}
    }
}
