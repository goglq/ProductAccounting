using ProductAccounting.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAccounting.Products
{
    public partial class ProductsForm : Form
    {
        private IReadOnlyDictionary<Button, Form> dialogs;

        public ProductsForm()
        {
            InitializeComponent();
            FillListView();

            dialogs = new Dictionary<Button, Form>
            {
                { button_Add, new CreateProductForm()},
                { button_Change, new ChangeProductForm()}
            };
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == dialogs[(Button)sender].ShowDialog())
                return;
            FillListView();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show($"Удалить товар: ", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;
            var selected_items = listView_Products.SelectedItems;
            //foreach (ListViewItem item in selected_items)
            //    ProductsContainer.Instance.Delete(new Product(item.SubItems.));

            FillListView();
        }

        private void FillListView()
        {
            listView_Products.Items.Clear();
            ProductsContainer.Instance.Products.ToList().ForEach(product => {
                AddProductToListView(product);
                });
        }

        private void AddProductToListView(KeyValuePair<Product, int> product)
        {
            ListViewItem item = new ListViewItem(product.Key.Name);
            item.SubItems.Add(product.Key.Note);
            item.SubItems.Add(product.Key.IsSplitting ? product.Key.Splitting.ToString() : "Нет");
            item.SubItems.Add(product.Key.IsSplitting ? product.Key.Measurement.ToString() : "...");
            item.SubItems.Add(product.Value.ToString());
            listView_Products.Items.Add(item);
        }
    }
}
