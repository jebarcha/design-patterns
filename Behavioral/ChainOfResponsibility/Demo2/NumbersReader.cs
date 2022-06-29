using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Demo2
{
    public class NumbersReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from a Numbers file");
        }

        protected override string GetFileExtension()
        {
            return ".numbers";
        }
    }
}
