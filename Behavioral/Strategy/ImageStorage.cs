using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ImageStorage
    {
        public void store(string fileName, ICompressor compressor, IFilter filter) 
        { 
            // JPEG, PNG, ...
            compressor.Compress(fileName);

            // B&W, High Contrast
            filter.Apply(fileName);
        }
    }
}
