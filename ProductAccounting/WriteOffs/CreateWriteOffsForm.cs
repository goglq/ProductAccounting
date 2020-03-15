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

        private void CreateProcurementForm_Load(object sender, EventArgs e)
        {
            WriteOffsContainer.Instance.Load();

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

            AddWriteOff();
            RefreshListView();
            comboBox_product.BackColor = Color.White;
        }

        private void FillComboBox()
        {

        }

        private void RefreshListView()
        {
            listView_products.Items.Clear();
            products.ToList().ForEach(product => AddProductToListView(product));
        }

        private void AddProductToListView(Product product)
        {
            ListViewItem item = new ListViewItem(product.Name);
            item.SubItems.Add(product.Quantity.ToString());
            item.Tag = product;
            listView_products.Items.Add(item);
        }

        private void AddWriteOff()
        {
            WriteOff writeOff = new WriteOff(dateTimePicker_writeOffDate.Value, textBox_master.Text, products);
            WriteOffsContainer.Instance.Add(writeOff);
        }
    }
}
