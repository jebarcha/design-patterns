using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class ImageView
    {
        private Image image;
        public ImageView(Image image)
        {
            this.image = image;
        }
        public void Apply(IFilter filter)
        {
            filter.Apply(image);
        }
    }
}
