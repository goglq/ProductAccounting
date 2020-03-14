using ProductAccounting.Data.Procurements;
using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProductAccounting.Procurements
{
    public partial class CreateProcurementForm : Form
    {
        private Procurement procurement;
        private IDictionary<Product, long> products = new Dictionary<Product, long>();

        public CreateProcurementForm()
        {
            InitializeComponent();
            numericUpDown_amount.Maximum = int.MaxValue;
        }

        private void CreateProcurementForm_Load(object sender, EventArgs e)
        {
            ProductsContainer.Instance.Load();
            checkBox_recieved.Checked = false;
            dateTimePicker_recieve.Enabled = false;

            procurement = null;
            products.Clear();
            FillComboBox();
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (comboBox_product.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар, который вы хотите добавить");
                comboBox_product.BackColor = Color.FromArgb(255, 200, 200);
                return;
            }

            Product productOnStock = (Product)comboBox_product.SelectedItem;
            Product soledProduct = productOnStock.Clone() as Product;
            soledProduct.LessQuantity = productOnStock.LessQuantity;
            
            if (soledProduct is null)
                throw new ArgumentNullException("Ошибка! Клонированный продукт равен null");
            
            AddProductWithPrice(soledProduct);
            FillListView();
            comboBox_product.BackColor = Color.White;
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
            Product productOnStock = (Product)comboBox_product.SelectedItem;
            productOnStock.Quantity += sellProduct.Quantity;

            products.Remove(sellProduct);
            FillListView();
        }

        private void Button_saveExit_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                procurement = new Procurement(dateTimePicker_recieve.Value, dateTimePicker_payment.Value, products, checkBox_recieved.Checked);
                if (procurement is null)
                    return;
                DialogResult = DialogResult.OK;
                ProcurementsContainer.Instance.Add(procurement);
            }

            ClearForm();
            Close();
        }

        private void ClearForm()
        {
            listView_products.Items.Clear();
            comboBox_product.Items.Clear();
            numericUpDown_amount.Value = numericUpDown_amount.Minimum;
            numericUpDown_price.Value = numericUpDown_price.Minimum;
        }

        private void FillListView()
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
            comboBox_product.Items.Clear();
            ProductsContainer.Instance.Products.ToList()
                .ForEach(product => {
                    comboBox_product.Items.Add(product);
                });
        }

        private void CheckBox_recieved_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_recieve.Enabled = checkBox_recieved.Checked;
        }
    }
}
