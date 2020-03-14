using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductAccounting.Data.Oddments
{
    public class OddmentsContainer
    {
        private static OddmentsContainer instance;

        public static OddmentsContainer Instance { get {
                if (instance is null)
                    instance = new OddmentsContainer();
                return instance;
            } }

        public bool IsChanged { get; private set; }

        private IList<Oddment> oddments;

        public IReadOnlyList<Oddment> Oddments => oddments.ToList();

        private OddmentsContainer()
        {
            oddments = new List<Oddment>();
            IsChanged = false;
        }

        public void Add(Oddment oddment)
        {
            oddments.Add(oddment);
            IsChanged = true;
        }

        public void Delete(Oddment oddment)
        {

        }

        public void Change(Oddment oldOddment, Oddment newOddment)
        {

        }
    }
}
