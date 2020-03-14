using ProductAccounting.Data.Procurements;
using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProductAccounting.Procurements
{
    public partial class ChangeProcurementForm : Form
    {
        private ListView listView;

        public Procurement Procurement { get; set; }
        private IDictionary<Product, long> products = new Dictionary<Product, long>();

        public ChangeProcurementForm(ListView listView)
        {
            InitializeComponent();

            this.listView = listView;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (comboBox_product.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар, который вы хотите добавить");
                comboBox_product.BackColor = Color.FromArgb(255, 200, 200);
                return;
            }

            Product productOnStock = (Product)comboBox_product.SelectedItem;
            Product soledProduct = productOnStock.Clone() as Product;

            if (soledProduct is null)
                throw new ArgumentNullException("Ошибка! Клонированный продукт равен null");

            AddProductWithPrice(soledProduct);
            RefreshListView();
            comboBox_product.BackColor = Color.White;
        }

        private void ChangeProcurementForm_Load(object sender, EventArgs e)
        {
            checkBox_recieved.Checked = false;
            dateTimePicker_recieve.Enabled = false;

            GetProcurementProducts();
            RefreshListView();

            FillComboBox();
            listView_products.Items[0].Selected = true;
        }

        private void GetProcurementProducts()
        {
            products.Clear();
            Procurement = (Procurement)listView.SelectedItems[0].Tag;
            Procurement.ProductsWithPrice
                .Select(keyValue => new KeyValuePair<Product, long>(keyValue.Key, keyValue.Value))
                .ToList()
                .ForEach(keyValue => products.Add(keyValue));
        }

        private void AddProductWithPrice(Product soledProduct)
        {
            Product productOnStock = (Product)comboBox_product.SelectedItem;
            soledProduct.Quantity += (int)numericUpDown_amount.Value;
            if (!products.ContainsKey(soledProduct))
            {
                products.Add(soledProduct, (long)numericUpDown_price.Value);
                return;
            }
            products.Keys.ToList()[products.Keys.ToList().IndexOf(soledProduct)].Quantity += soledProduct.Quantity;
            products[soledProduct] = (long)numericUpDown_price.Value;
        }

        private void Button_remove_Click(object sender, EventArgs e)
        {
            if (listView_products.SelectedItems.Count == 0)
                return;
            Product sellProduct = (Product)listView_products.SelectedItems[0].Tag;
            Product productOnStock = ProductsContainer.Instance.Products
                .Where(product => 
                sellProduct.Name == product.Name
                && sellProduct.Note == product.Note
                && sellProduct.Measurement == product.Measurement
                && sellProduct.Splitting == product.Splitting
                && sellProduct.IsSplitting == product.IsSplitting).First();

            productOnStock.Quantity += sellProduct.Quantity;

            products.Remove(sellProduct);
            RefreshListView();
        }

        private void Button_saveExit_Click(object sender, EventArgs e)
        {
            if(products.Count == 0)
            {
                ProcurementsContainer.Instance.Delete((Procurement)listView.SelectedItems[0].Tag);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            Procurement = new Procurement(dateTimePicker_recieve.Value, dateTimePicker_payment.Value, products, checkBox_recieved.Checked);
            if (Procurement is null)
                return;
            DialogResult = DialogResult.OK;
            ProcurementsContainer.Instance.Change((Procurement)listView.SelectedItems[0].Tag, Procurement);
            Close();
        }

        private void RefreshListView()
        {
            listView_products.Items.Clear();
            foreach (KeyValuePair<Product, long> product_and_price in products)
                AddProductListViewItem(product_and_price.Key, product_and_price.Value);
        }

        private void AddProductListViewItem(Product product, long price)
        {
            if (product is null)
                return;

            ListViewItem item = new ListViewItem(product.Name);
            item.SubItems.Add(product.Quantity.ToString());
            item.SubItems.Add(price.ToString());
            item.Tag = product;
            listView_products.Items.Add(item);
        }

        private void CreateProcurementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            products.Clear();
        }

        private void FillComboBox()
        {
            ProductsContainer.Instance.Load();
            ProductsContainer.Instance.Products.ToList()
                .ForEach(product => comboBox_product.Items.Add(product));
        }

        private void CheckBox_recieved_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_recieve.Enabled = checkBox_recieved.Checked;
        }
    }
}
