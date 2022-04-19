using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Demo2.WithTheProblem
{
    public class Scheduler
    {
        private Calendar _calendar = new Calendar();
        public void Schedule(Event sEvent) 
        {
            var today = new DateTime();
            _calendar.AddEvent(sEvent, today);
        }
    }
}
