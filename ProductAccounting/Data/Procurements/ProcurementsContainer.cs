using ProductAccounting.Data.Oddments;
using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductAccounting.Data.Procurements
{
    public class ProcurementsContainer
    {
        private static ProcurementsContainer instance;

        public static ProcurementsContainer Instance {
            get {
                if (instance is null)
                    instance = new ProcurementsContainer();
                return instance;
            }
        }

        private IList<Procurement> procurements;

        public IReadOnlyList<Procurement> Procurements => procurements.ToList();

        public bool IsChanged { get; private set; }

        private ProcurementsContainer() {
            procurements = new List<Procurement>();
            IsChanged = false;
        }

        public void Add(Procurement procurement)
        {
            IsChanged = true;
            procurements.Add(procurement);
            OddmentsContainer.Instance.Update();
        }

        public void Delete(Procurement procurement)
        {
            procurements.Remove(procurement);

            IsChanged = true;
            OddmentsContainer.Instance.Update();
        }

        public void Change(Procurement oldProcurement, Procurement newProcurement)
        {
            if (!Procurements.Contains(oldProcurement))
                return;
            if (oldProcurement == newProcurement)
                return;

            procurements[procurements.IndexOf(oldProcurement)] = newProcurement;
            IsChanged = true;
            OddmentsContainer.Instance.Update();
        }

        public void Save()
        {
            XElement xml = new XElement(
                "procurements",
                procurements.Select(procurement => procurement.ToXml()));

            xml.Save(SavePath.Instance.ProcurementsSavePath);

            IsChanged = false;
        }

        public void Load()
        {
            if (!File.Exists(SavePath.Instance.ProcurementsSavePath))
                return;

            procurements = XElement.Load(SavePath.Instance.ProcurementsSavePath)
                .Elements("procurement")
                .Select(node => Procurement.FromXml(node))
                .ToList();
        }
    }
}
