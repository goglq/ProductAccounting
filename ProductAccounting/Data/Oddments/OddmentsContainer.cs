using ProductAccounting.Data.Procurements;
using ProductAccounting.Data.Products;
using ProductAccounting.Data.WriteOffs;
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

        private IList<Oddment> oddments;

        public IReadOnlyList<Oddment> Oddments => oddments.ToList();

        private OddmentsContainer()
        {
            oddments = new List<Oddment>();
            Update();
        }

        public void Update()
        {
            oddments.Clear();
            ProductsContainer.Instance.Products.ToList().ForEach(product => Add(product));
        }

        public void Add(Product product)
        {
            if (!product.IsSplitting) {
                //Сумма количества определенных (product) товаров из закупок
                int sum_quantity_from_procurements = ProcurementsContainer.Instance.Procurements
                    .Where(procurement => procurement.IsRecieved)
                    .Select(procurement => procurement.ProductsWithPrice.Keys.Where(keyProduct => product == keyProduct)
                    .Select(foundProduct => foundProduct.Quantity).Sum()).Sum();

                //Сумма количества определенных (product) товаров из списаний
                int sum_quantity_from_writeoffs = WriteOffsContainer.Instance.WriteOffs
                    .Select(writeOff => writeOff.Products
                    .Where(inWriteOffProduct => product == inWriteOffProduct)
                    .Select(writeOffProduct => writeOffProduct.Quantity).Sum()).Sum();

                //Разница
                int quantity_left = sum_quantity_from_procurements - sum_quantity_from_writeoffs;
                int splitting_left = 0;
                oddments.Add(new Oddment(product, quantity_left, splitting_left));
            }
            else
            {
                int sum_splitting_from_procurements = ProcurementsContainer.Instance.Procurements
                    .Where(procurement => procurement.IsRecieved)
                    .Select(procurement => procurement.ProductsWithPrice.Keys.Where(keyProduct => product == keyProduct)
                    .Select(foundProduct => foundProduct.AmountInMeasurement).Sum()).Sum();

                int sum_splitting_from_writeoffs = WriteOffsContainer.Instance.WriteOffs
                    .Select(writeOff => writeOff.Products
                    .Where(inWriteOffProduct => product == inWriteOffProduct)
                    .Select(writeOffProduct => writeOffProduct.AmountInMeasurement).Sum()).Sum();

                //Разница
                int quantity_left = (sum_splitting_from_procurements - sum_splitting_from_writeoffs) / (int)product.Splitting;
                int splitting_left = sum_splitting_from_procurements - sum_splitting_from_writeoffs;
                oddments.Add(new Oddment(product, quantity_left, splitting_left));
            }
        }
    }
}
