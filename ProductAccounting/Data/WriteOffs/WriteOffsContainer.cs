using ProductAccounting.Data.Oddments;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductAccounting.Data.WriteOffs
{
    public class WriteOffsContainer
    {
        private static WriteOffsContainer instance;

        public static WriteOffsContainer Instance { get {
                if (instance is null)
                    instance = new WriteOffsContainer();
                return instance;
            } }

        private IList<WriteOff> writeOffs;

        public IReadOnlyList<WriteOff> WriteOffs => writeOffs.ToList();

        public bool IsChanged { get; private set; }

        private WriteOffsContainer()
        {
            IsChanged = false;
            writeOffs = new List<WriteOff>();
        }

        public void Add(WriteOff writeOff)
        {
            writeOffs.Add(writeOff);
            IsChanged = true;
            OddmentsContainer.Instance.Update();
        }

        public void Delete(WriteOff writeOff)
        {
            if (!writeOffs.Contains(writeOff))
                throw new ArgumentException("Такого списания не сущетсвует");

            writeOffs.Remove(writeOff);
            IsChanged = true;
            OddmentsContainer.Instance.Update();
        }

        public void Change(WriteOff oldWriteOff, WriteOff newWriteOff)
        {
            if (!writeOffs.Contains(oldWriteOff))
                return;
            if (oldWriteOff == newWriteOff)
                return;

            writeOffs[writeOffs.IndexOf(oldWriteOff)] = newWriteOff;
            IsChanged = true;
            OddmentsContainer.Instance.Update();
        }

        public void Save()
        {
            XElement xml = new XElement(
                "writeOffs",
                writeOffs.Select(writeOff => writeOff.ToXml()));

            xml.Save(SavePath.Instance.WriteOffsSavePath);

            IsChanged = false;
        }

        public void Load()
        {
            if (!File.Exists(SavePath.Instance.WriteOffsSavePath))
                return;

            writeOffs = XElement.Load(SavePath.Instance.WriteOffsSavePath)
                .Elements("writeOff")
                .Select(node => WriteOff.FromXml(node))
                .ToList();
        }
    }
}
