using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Iterator.Demo2
{
    public class ProductCollection
    {
        private List<Product> products = new List<Product>();

        public void Add(Product product)
        {
            products.Add(product);
        }
        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : IIterator
        {
            private ProductCollection collection;
            private int _index;

            public ListIterator(ProductCollection collection)
            {
                this.collection = collection;
            }

            public bool HasNext()
            {
                return (_index < collection.products.Count());
            }

            public Product Current()
            {
                return collection.products[_index];
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}
