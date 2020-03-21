using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProductAccounting.Data.Products
{
    public class Product : ICloneable
    {
        public string Name { get; set; }

        public string Note { get; set; }

        public bool IsSplitting { get; set; }

        public decimal Splitting { get; set; }

        public int AmountInMeasurement { get; set; }

        public Measurement Measurement { get; set; }

        public int LessQuantity { get; set; }

        public int Quantity { get; set; }

        public Product(string name, string note)
        {
            AmountInMeasurement = 0;
            LessQuantity = 1;
            Quantity = 0;
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
            if (obj is System.DBNull)
                return false;

            var that = obj as Product;
            return this.Name == that.Name &&
                   this.Note == that.Note &&
                   this.IsSplitting == that.IsSplitting &&
                   this.Splitting == that.Splitting &&
                   this.Measurement == that.Measurement &&
                   this.LessQuantity == that.LessQuantity;
        }

        public override int GetHashCode()
        {
            var hashCode = -748668788;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Note);
            hashCode = hashCode * -1521134295 + IsSplitting.GetHashCode();
            hashCode = hashCode * -1521134295 + Splitting.GetHashCode();
            hashCode = hashCode * -1521134295 + Measurement.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Product left, Product right) => left.Equals(right);
        public static bool operator !=(Product left, Product right) => !left.Equals(right);

        public XElement ToXml() =>
            new XElement(
                    "product",
                    new XAttribute("isSplitting", IsSplitting),
                    new XAttribute("lessQuantity", LessQuantity),
                    new XElement("quantity", Quantity),
                    new XElement("name", Name),
                    new XElement("note", Note),
                    new XElement("splitting", Splitting),
                    new XElement("measurement", (int)Measurement),
                    new XElement("amountMeasurement", AmountInMeasurement));

        public static Product FromXml(XElement xElement) => (bool)xElement.Attribute("isSplitting") ?
            new Product(
                (string)xElement.Element("name"),
                (string)xElement.Element("note"),
                (decimal)xElement.Element("splitting"),
                (Measurement)(int)xElement.Element("measurement"))
            {
                Quantity = (int)xElement.Element("quantity"),
                LessQuantity = (int)xElement.Attribute("lessQuantity"),
                AmountInMeasurement = (int)xElement.Element("amountMeasurement")
            } :
            new Product(
                (string)xElement.Element("name"),
                (string)xElement.Element("note"))
            {
                Quantity = (int)xElement.Element("quantity"),
                LessQuantity = (int)xElement.Attribute("lessQuantity")
            };

        public object Clone()
        {
            if(IsSplitting)
            {
                Product clone = new Product(Name, Note, Splitting, Measurement);
                clone.LessQuantity = LessQuantity;
                return clone;
            }
            else
            {
                Product clone = new Product(Name, Note);
                clone.LessQuantity = LessQuantity;
                return clone;
            }
        }
    }
}
