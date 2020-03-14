using ProductAccounting.Data;
using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProductAccounting.Products
{
    public partial class ProductsForm : Form
    {
        private IReadOnlyDictionary<Button, Form> dialogs;

        public ProductsForm()
        {
            InitializeComponent();

            dialogs = new Dictionary<Button, Form>
            {
                { button_Add, new CreateProductForm()},
                { button_Change, new ChangeProductForm(listView_Products)}
            };
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            ProductsContainer.Instance.Load();
            FillListView();
        }

        private void Button_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if((Button)sender == button_Change && listView_Products.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите продукт, который будет отредактирован!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DialogResult.Cancel == dialogs[(Button)sender].ShowDialog())
                return;

            FillListView();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show($"Удалить товар: ", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;
            if (!(listView_Products.SelectedItems[0].Tag is Product))
                throw new ArgumentException("Ошибка! Передана переменная неправильного типа");

            ProductsContainer.Instance.Delete((Product)listView_Products.SelectedItems[0].Tag);
            FillListView();
        }

        private void FillListView()
        {
            listView_Products.Items.Clear();
            ProductsContainer.Instance.Products.ToList().ForEach(product => AddProductToListView(product));
        }

        private void AddProductToListView(Product product)
        {
            ListViewItem item = new ListViewItem(product.Name);
            item.SubItems.Add(product.Note);
            item.SubItems.Add(product.IsSplitting ? product.Splitting.ToString() : "Нет");
            item.SubItems.Add(product.IsSplitting ? product.Measurement.ToString() : "...");
            item.SubItems.Add(product.Quantity.ToString());
            item.Tag = product;
            listView_Products.Items.Add(item);
        }

        private void ProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ProductsContainer.Instance.IsChanged)
                return;

            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    ProductsContainer.Instance.Save();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    break;
                default:
                    throw new InvalidOperationException("Ошибка! Не удалось распознать выбор пользователя.");
            }
        }
    }
}
