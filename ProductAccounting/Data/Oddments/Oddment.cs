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
        private Product product;

        public int ProductQuantityLeft { get; set; }

        public int ProductSplittingLeft { get; set; }
    }
}
