using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Demo2
{
    public class ExcelReader : DataReader
    {
        protected override void DoRead(string fileName)
        {
            Console.WriteLine("Reading data from an Excel file");
        }

        protected override string GetFileExtension()
        {
            return ".xls";
        }
    }
}
