using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public interface IViewEngine
    {
        string Render(string viewName, Dictionary<string, object> context);
    }
}
