using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.TemplateMethod 
{
    public class TransferMoneyTask : Task
    {
        ////public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        ////{
        ////}

        //private AuditTrail _auditTrail;
        //public TransferMoneyTask(AuditTrail auditTrail)
        //{
        //    _auditTrail = auditTrail;
        //}

        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }

        //public void Execute()
        //{
        //    _auditTrail.Record();

        //    Console.WriteLine("Transfer Money");
        //}
    }
}
