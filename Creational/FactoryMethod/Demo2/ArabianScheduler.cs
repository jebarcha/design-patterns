using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Demo2
{
    public class ArabianScheduler : Scheduler
    {
        protected override ICalendar CreateCalendar()
        {
            return new ArabianCalendar();
        }
    }
}
