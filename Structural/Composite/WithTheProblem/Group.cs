using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.WithTheProblem
{
    public class Group
    {
        private List<Object> objects = new List<Object>();

        public void Add(Object shape)
        {
            objects.Add(shape);
        }
        public void Render()
        {
            foreach (var @object in objects)
            {
                if (@object is Shape) {
                    ((Shape)@object).Render();
                }
                else
                {
                    ((Group)@object).Render();
                }
            }
        }
    }
}
