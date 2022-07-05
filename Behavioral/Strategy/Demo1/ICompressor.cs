using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface ICompressor
    {
        //byte[] Compress(byte[] data);
        void Compress(string fileName);

    }
}
