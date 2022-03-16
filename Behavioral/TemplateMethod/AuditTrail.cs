using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit");
        }
    }
}
