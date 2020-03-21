using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccounting.Data.Oddments
{
    public class Oddment
    {
        public Product Product { get; }

        public int ProductQuantityLeft { get; set; }

        public int ProductSplittingLeft { get; set; }

        public Oddment(Product product, int productQuantityLeft, int productSplittingLeft)
        {
            Product = product;
            ProductQuantityLeft = productQuantityLeft;
            ProductSplittingLeft = productSplittingLeft;
        }
    }
}
