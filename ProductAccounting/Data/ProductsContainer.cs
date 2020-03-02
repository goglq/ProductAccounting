using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        public bool IsChanged { get; private set; }
        public IList<Product> Products { get; private set; }

        private ProductsContainer()
        {
            Products = new List<Product>();
            IsChanged = false;
        }

        public void Add(Product product)
        {
            if (Products.Contains(product))
            {
                Products[Products.IndexOf(product)].Quantity += 1;
                return;
            }

            Products.Add(product);
            IsChanged = true;
        }

        public void Change(Product oldProduct, Product changedProduct)
        {
            if (!Products.Contains(oldProduct))
                throw new InvalidOperationException("Ошибка! Данного элемента в коллекции не существует.");
            if (oldProduct == changedProduct)
                return;

            Products[Products.IndexOf(oldProduct)] = changedProduct;

            IsChanged = true;
        }

        public void Delete(Product product) {
            Products.Remove(product);
            IsChanged = true;
        }

        public void Save()
        {
            XElement xml = new XElement(
                "products",
                Products.Select(product => product.ToXml()));
            xml.Save(SavePath.Instance.ProductsSavePath);

            IsChanged = false;
        }

        public void Load()
        {
            if (!File.Exists(SavePath.Instance.ProductsSavePath))
                return;

            Products = XElement.Load(SavePath.Instance.ProductsSavePath)
              .Elements("product")
              .Select(node => Product.FromXml(node))
              .ToList();
        }
    }
}
