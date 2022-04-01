using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class CompressCloudStream : IStream
    {
        private IStream _stream;
        public CompressCloudStream(IStream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var compressed = Compress(data);
            _stream.Write(compressed);
        }
        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
