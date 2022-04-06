using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class SpreadSheet : IObserver
    {
        private DataSource _dataSource;
        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"SpreadSheet got notified: {_dataSource.GetValue()}");
        }
    }
}
