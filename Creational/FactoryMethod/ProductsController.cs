using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class ProductsController : SharpController // Controller
    {
        public void ListProducts()
        {
            // Get products from a db
            Dictionary<string, object> context = new Dictionary<string, object>();
            // context.put(products);
            Render("products.html", context);
        }
    }
}
