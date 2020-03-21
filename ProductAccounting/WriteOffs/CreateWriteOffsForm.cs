using ProductAccounting.Data.Products;
using ProductAccounting.Data.WriteOffs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProductAccounting.WriteOffs
{
    public partial class CreateWriteOffsForm : Form
    {
        private IList<Product> products;

        public CreateWriteOffsForm()
        {
            InitializeComponent();

            products = new List<Product>();
        }

        private void CreateWriteOffForm_Load(object sender, EventArgs e)
        {
            WriteOffsContainer.Instance.Load();
            ProductsContainer.Instance.Load();

            comboBox_product.Items.Clear();
            products.Clear();
            RefreshListView();
            textBox_master.Text = "";

            FillComboBox();
            label_measurement.Text = "единица измерения";
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (comboBox_product.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите товар, который вы хотите добавить");
                comboBox_product.BackColor = Color.FromArgb(255, 200, 200);
                return;
            }

            AddProduct();
            RefreshListView();
            comboBox_product.BackColor = Color.White;
        }

        private void AddProduct()
        {
            Product selectedProduct = comboBox_product.SelectedItem as Product;

            if (selectedProduct is null)
                throw new ArgumentNullException("Ошибка при возвращении продукта из comboBox_product (возвращает null)");

            Product writeOffProduct = (Product)selectedProduct.Clone();
            if (writeOffProduct.IsSplitting)
                writeOffProduct.AmountInMeasurement = (int)numericUpDown_used.Value;
            else
                writeOffProduct.Quantity = (int)numericUpDown_used.Value;

            products.Add(writeOffProduct);
            numericUpDown_used.Value = 0;
        }

        private void FillComboBox()
        {
            ProductsContainer.Instance.Products.ToList()
                .ForEach(product => comboBox_product.Items.Add(product));
        }

        private void RefreshListView()
        {
            listView_products.Items.Clear();
            products.ToList().ForEach(product => AddProductToListView(product));
        }

        private void AddProductToListView(Product product)
        {
            ListViewItem item = new ListViewItem(product.Name);
            item.SubItems.Add(product.IsSplitting ? product.AmountInMeasurement.ToString() : product.Quantity.ToString());
            item.SubItems.Add(product.IsSplitting ? product.Measurement.ToString() : "шт.");
            item.Tag = product;
            listView_products.Items.Add(item);
        }

        private void AddWriteOff()
        {
            WriteOff writeOff = new WriteOff(dateTimePicker_writeOffDate.Value, textBox_master.Text, products);
            WriteOffsContainer.Instance.Add(writeOff);
        }

        private void ComboBox_product_SelectedValueChanged(object sender, EventArgs e)
        {
            Product selectedProduct = comboBox_product.SelectedItem as Product;

            if (selectedProduct is null)
                throw new ArgumentNullException("Ошибка при возвращении продукта из comboBox_product (возвращает null)");

            label_measurement.Text = selectedProduct.IsSplitting 
                ? selectedProduct.Measurement.ToString() 
                : "Штук";
        }

        private void Button_remove_Click(object sender, EventArgs e)
        {
            Product product = listView_products.SelectedItems[0].Tag as Product;

            if(product is null)
                throw new ArgumentNullException("Ошибка при возвращении продукта из tag (возвращает null)");

            products.Remove(product);
            RefreshListView();
        }

        private void Button_saveExit_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                Close();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_master.Text))
            {
                textBox_master.BackColor = Color.FromArgb(255, 200, 200);
                return;
            }

            textBox_master.BackColor = Color.White;
            AddWriteOff();
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
