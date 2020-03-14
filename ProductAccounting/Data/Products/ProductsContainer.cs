using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ProductAccounting.Data.Products
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

        private IList<Product> products;

        public bool IsChanged { get; private set; }
        public IReadOnlyList<Product> Products => (List<Product>)products;

        private ProductsContainer()
        {
            products = new List<Product>();
            IsChanged = false;
        }

        public void Add(Product product)
        {
            IsChanged = true;
            if (products.Contains(product))
            {
                products[products.IndexOf(product)].Quantity += 1;
                return;
            }

            products.Add(product);
        }

        public void Change(Product oldProduct, Product changedProduct)
        {
            if (!products.Contains(oldProduct))
                throw new InvalidOperationException("Ошибка! Данного элемента в коллекции не существует.");
            if (oldProduct == changedProduct)
                return;

            products[products.IndexOf(oldProduct)] = changedProduct;

            IsChanged = true;
        }

        public void Delete(Product product) {
            products.Remove(product);
            IsChanged = true;
        }

        public void Save()
        {
            XElement xml = new XElement(
                "products",
                products.Select(product => product.ToXml()));
            xml.Save(SavePath.Instance.ProductsSavePath);

            IsChanged = false;
        }

        public void Load()
        {
            if (!File.Exists(SavePath.Instance.ProductsSavePath))
                return;

            products = XElement.Load(SavePath.Instance.ProductsSavePath)
              .Elements("product")
              .Select(node => Product.FromXml(node))
              .ToList();
        }
    }
}
