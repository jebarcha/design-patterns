using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ImageStorage_ToFix
    {
        private string compressor;
        private string filter;

        public ImageStorage_ToFix(string compressor, string filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void store(string fileName) 
        { 
            // JPEG, PNG, ...
            // B&W, High Contrast
            if (compressor == "jpeg")
            {
                Console.WriteLine("Compressing using JPEG");
            }
            else if (compressor == "png")
            {
                Console.WriteLine("Compresisng using PNG");
            }

            if (filter == "b&w")
            {
                Console.WriteLine("Applying B&W filter");
            } else if (filter == "high-contrast")
            {
                Console.WriteLine("Applying high contrast filter");
            }
        }
    }
}
