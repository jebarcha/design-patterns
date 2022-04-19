using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Demo2
{
    public interface ICalendar
    {
        void AddEvent(Event sEvent, DateTime date); 
    }
}
