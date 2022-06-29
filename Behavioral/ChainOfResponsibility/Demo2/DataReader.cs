using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility.Demo2
{
    public abstract class DataReader
    {
        private DataReader _next;
        public void SetNext(DataReader next)
        {
            _next = next;
        }
        public void Read(string fileName)
        {
            string fileExtension = GetFileExtension();
            if (fileName.EndsWith(fileExtension))
            {
                DoRead(fileName);
                return;
            }
            if(_next is not null)
            {
                _next.Read(fileName);
            }
            else
            {
                throw new InvalidOperationException("File format not supported.");
            }

        }
        protected abstract string GetFileExtension();
        protected abstract void DoRead(string fileName);
    }
}
