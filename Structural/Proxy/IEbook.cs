using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public interface IEbook
    {
        public void Show();
        public string GetFileName();
    }
}
