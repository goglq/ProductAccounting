using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductAccounting.Data.WriteOffs
{
    public class WriteOff
    {
        private IList<Product> products;

        public IReadOnlyList<Product> Products => products.ToList();

        public DateTime Date { get; set; }

        public string Master { get; set; }

        public WriteOff(DateTime date, string master, IList<Product> products)
        {
            Date = date;
            Master = master;
            this.products = new List<Product>();
            products.ToList().ForEach(product => this.products.Add(product));
        }

        public XElement ToXml() => new XElement("writeOff",
            new XElement("date", Date),
            new XElement("master", Master),
            new XElement("products", products.Select(product => product.ToXml())));

        public static WriteOff FromXml(XElement xElement) =>
            new WriteOff(
                (DateTime)xElement.Element("date"),
                (string)xElement.Element("master"),
                xElement.Element("products").Elements("product").Select(node => Product.FromXml(node)).ToList());

        public override string ToString()
        {
            string str = "";
            products.ToList()
                .ForEach(product => str += $"{product.Quantity}x {product.ToString()}, ");
            return str.ToString();
        }
    }
}
