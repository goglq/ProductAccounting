using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductAccounting.Data
{
    public class Product
    {
        public string Name { get; set; }

        public string Note { get; set; }

        public bool IsSplitting { get; set; }

        public decimal Splitting { get; set; }

        public Measurement Measurement { get; set; }

        public int Quantity { get; set; }

        public Product(string name, string note)
        {
            Quantity = 1;
            Name = name;
            Note = note;
            IsSplitting = false;
        }

        public Product(string name, string note, decimal splitting, Measurement measurement) : this(name, note)
        {
            IsSplitting = true;
            Splitting = splitting;
            Measurement = measurement;
        }

        public override string ToString() => Name;

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;

            var that = obj as Product;
            return this.Name == that.Name &&
                   this.Note == that.Note &&
                   this.IsSplitting == that.IsSplitting &&
                   this.Splitting == that.Splitting &&
                   this.Measurement == that.Measurement;
        }

        public override int GetHashCode()
        {
            var hashCode = -748668788;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Note);
            hashCode = hashCode * -1521134295 + IsSplitting.GetHashCode();
            hashCode = hashCode * -1521134295 + Splitting.GetHashCode();
            hashCode = hashCode * -1521134295 + Measurement.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Product left, Product right) => left.Equals(right);
        public static bool operator !=(Product left, Product right) => !left.Equals(right);

        public XElement ToXml() =>
            new XElement(
                    "product",
                    new XAttribute("isSplitting", IsSplitting),
                    new XAttribute("quantity", Quantity),
                    new XElement("name", Name),
                    new XElement("note", Note),
                    new XElement("splitting", Splitting),
                    new XElement("measurement", (int)Measurement));

        public static Product FromXml(XElement xElement) =>
            (bool)xElement.Attribute("isSplitting") ? 
            new Product(
                (string)xElement.Element("name"),
                (string)xElement.Element("note"),
                (decimal)xElement.Element("splitting"),
                (Measurement)(int)xElement.Element("measurement")) { Quantity = (int)xElement.Attribute("quantity") } :
            new Product(
                (string)xElement.Element("name"), 
                (string)xElement.Element("note")) { Quantity = (int)xElement.Attribute("quantity") };
    }
}
