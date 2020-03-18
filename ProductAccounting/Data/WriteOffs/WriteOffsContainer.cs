using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public void Delete(WriteOff writeOff)
        {
            if (!writeOffs.Contains(writeOff))
                throw new ArgumentException("Такого списания не сущетсвует");

            writeOffs.Remove(writeOff);
        }

        public void Change(WriteOff oldWriteOff, WriteOff newWriteOff)
        {
            if (!writeOffs.Contains(oldWriteOff))
                return;
            if (oldWriteOff == newWriteOff)
                return;

            writeOffs[writeOffs.IndexOf(oldWriteOff)] = newWriteOff;
            IsChanged = true;
        }

        public void Save()
        {

        }

        public void Load()
        {

        }
    }
}
