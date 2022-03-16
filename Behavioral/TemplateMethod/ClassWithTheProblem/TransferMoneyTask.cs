using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod.WithTheProblem
{
    public class TransferMoneyTask
    {
        private AuditTrail _auditTrail;
        public TransferMoneyTask(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();

            Console.WriteLine("Transfer Money");
        }
    }
}
