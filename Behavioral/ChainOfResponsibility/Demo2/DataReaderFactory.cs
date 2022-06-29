using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Demo2
{
    public class DataReaderFactory
    {
        public static DataReader GetDataReaderChain()
        {
            var excelReader = new ExcelReader();
            var numbersReader = new NumbersReader();
            var quickBooksReader = new QuickBooksReader();

            quickBooksReader.SetNext(numbersReader);
            numbersReader.SetNext(excelReader);

            return quickBooksReader;
        }
    }
}
