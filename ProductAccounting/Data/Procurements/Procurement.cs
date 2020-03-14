using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductAccounting.Data.Procurements
{
    public class Procurement
    {
        private IDictionary<Product, long> productsWithPrice;

        public bool IsRecieved { get; set; }

        public DateTime RecieveDate { get; set; }

        public DateTime PaymentDate { get; set; }

        public IReadOnlyDictionary<Product, long> ProductsWithPrice =>
            productsWithPrice.ToDictionary(product => product.Key, product => product.Value);

        public long TotalPrice => ProductsWithPrice.Select(product => product.Value * product.Key.Quantity).Sum();

        public string Orders { get {
                IList<string> order = new List<string>();
                StringBuilder stringBuilder = new StringBuilder();
                ProductsWithPrice
                    .Select(keyValue => keyValue.Key).ToList()
                    .ForEach(product => stringBuilder.Append(product));
                return stringBuilder.ToString();
            } }

        public Procurement(DateTime recieveDate, DateTime paymentDate, IDictionary<Product, long> productsWithPrice, bool isRecieved)
        {
            IsRecieved = isRecieved;
            RecieveDate = recieveDate;
            PaymentDate = paymentDate;
            this.productsWithPrice = new Dictionary<Product, long>();
            foreach(KeyValuePair<Product, long> keyValue in productsWithPrice)
                this.productsWithPrice.Add(new KeyValuePair<Product, long>(keyValue.Key, keyValue.Value));
            
        }

        public XElement ToXml() =>
            new XElement("procurement",
                new XElement("recieveDate", RecieveDate),
                new XElement("paymentDate", PaymentDate),
                new XElement("isRecieved", IsRecieved),
                new XElement("products",
                    ProductsWithPrice.Select(product => {
                        XElement xElement = product.Key.ToXml();
                        xElement.Add(new XAttribute("price", product.Value));
                        return xElement;
                    })));

        public static Procurement FromXml(XElement xElement) => new Procurement(
                recieveDate: (DateTime)xElement.Element("recieveDate"),
                paymentDate: (DateTime)xElement.Element("paymentDate"),
                isRecieved: (bool)xElement.Element("isRecieved"),
                productsWithPrice: xElement.Element("products").Elements("product").ToDictionary(
                    product => Product.FromXml(product),
                    product => (long)product.Attribute("price")));

        public override string ToString()
        {
            IList<string> order = new List<string>();
            string str = "";
            ProductsWithPrice
                .Select(keyValue => keyValue.Key).ToList()
                .ForEach(product => str += $"{product.Quantity}x {product.ToString()}, ");
            return str.ToString();
        }
    }
}
