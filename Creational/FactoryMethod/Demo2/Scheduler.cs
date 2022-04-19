using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Demo2
{
    public class Scheduler
    {
        private ICalendar _calendar;

        public Scheduler()
        {
            _calendar = CreateCalendar();
        }

        protected virtual ICalendar CreateCalendar()
        {
            return new GregorianCalendar();
        }
        public void Schedule(Event sEvent) 
        {
            var today = new DateTime();
            _calendar.AddEvent(sEvent, today);
        }
    }
}
