using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class GenerateReportTask
    {
        private AuditTrail _audiTrail;
        public GenerateReportTask(AuditTrail audiTrail)
        {
            _audiTrail = audiTrail;
        }
        public void Execute()
        {
            _audiTrail.Record();

            Console.WriteLine("Generate Report");
        }
    }
}
