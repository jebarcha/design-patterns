using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class Square : IComponent
    {
        private int _size;
        public int Area => _size * _size;
        public IComponent clone()
        {
            Square newSquare = new Square();
            newSquare._size = _size;
            return newSquare;
        }
        public void SetSize(int size) => _size = size;
        public void Render()
        {
            Console.WriteLine("Rendering a Square");
        }
    }
}
