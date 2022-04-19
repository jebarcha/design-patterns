using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class SharpViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View rendred by Sharp";
        }
    }
}
