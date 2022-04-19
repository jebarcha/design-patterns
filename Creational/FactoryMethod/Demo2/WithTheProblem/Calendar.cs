using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Demo2.WithTheProblem
{
    public class Calendar
    {
        public void AddEvent(Event sEvent, DateTime date) 
        {
            Console.WriteLine("Adding an event on the given date.");
        }
    }
}
