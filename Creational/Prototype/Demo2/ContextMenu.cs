using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype.Demo2
{
    public class ContextMenu
    {
        private Timeline _timeline;
        public ContextMenu(Timeline timeline)
        {
            _timeline = timeline;
        }
        public void Duplicate(IComponent component)
        {
            IComponent newComponent = component.Clone();
            _timeline.Add(newComponent);


            //if (component is Text) 
            //{
            //    Text source = (Text)component;
            //    Text target = new Text(source.GetContent());
            //    _timeline.Add(target);
            //}
            //else if (component is Audio) 
            //{
            //    // Logic for duplicating an Audio object
            //}
            //else if (component is Clip) 
            //{
            //    // Logic for duplicating a Clip object
            //}
        }
        //ublic Timeline GetTimelines() => _timeline;
    }
}
