using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAccounting.Data
{
    public class ProductsContainer
    {
        private static ProductsContainer instance;

        public static ProductsContainer Instance {
            get {
                if (instance == null)
                    instance = new ProductsContainer();
                return instance;
            }
        }

        public IDictionary<Product, int> Products { get; }

        private ProductsContainer()
        {
            Products = new Dictionary<Product, int>();
        }

        public void Add(Product product)
        {
            if (Products.ContainsKey(product))
            {
                Products[product]++;
                return;
            }

            Products.Add(new KeyValuePair<Product, int>(product , 1));
        }

        public void Change(Product oldProduct, Product changedProduct) {
            
        }

        public void Delete(Product product) => Products.Remove(product);
    }
}
