using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class BasketManager
    {
        // naming convention
        // syntax
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi:" + product.Name);
        }
    }
}
