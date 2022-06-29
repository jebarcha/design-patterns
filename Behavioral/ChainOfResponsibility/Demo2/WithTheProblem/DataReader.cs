using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Demo2.WithTheProblem
{
    public class DataReader
    {
        public void Read(string fileName)
        {
            if (fileName.EndsWith(".xls"))
            {
                Console.WriteLine("Reading data from an Excel spreadsheet.");
            }
            else if (fileName.EndsWith(".numbers"))
            {
                Console.WriteLine("Reading data from a Numbers spreadsheet.");
            }
            else if (fileName.EndsWith(".qbw"))
            {
                Console.WriteLine("Reading data from a QuickBooks file.");
            }
            else
                throw new InvalidOperationException("File format not supported.");
        }
    }
}
