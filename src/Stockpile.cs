using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.src
{
    class Stockpile
    {
        private List<Product> products;

        public IList<Product> getProducts()
        {
            return products.AsReadOnly();
        }

        public Stockpile(List<Product> products)
        {
            this.products  = products;
        }

        public void addNewProduct(Product product)
        {
            products.Add(product);
        }

        public void removeProducte(Product product)
        {
            products.Remove(product);
        }
    }
}
