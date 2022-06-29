using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Demo2
{
    public interface DocumentBuilder
    {
        void AddText(Text text);
        void AddImage(Image image);
        string GetResult();
    }
}
