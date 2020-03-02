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
    public partial class ChangeProductForm : Form
    {
        private ListView productView;

        public ChangeProductForm(ListView listView)
        {
            InitializeComponent();
            productView = listView;

            Measurement[] measurement = (Measurement[])Enum.GetValues(typeof(Measurement));
            measurement.ToList().ForEach(m => comboBox_Measurement.Items.Add(m));
        }

        private void ChangeProductForm_Load(object sender, EventArgs e)
        {
            if (!(productView.SelectedItems[0].Tag is Product))
                throw new InvalidOperationException("Ошибка! Передана переменная с неправильным типом.");

            Product selectedProduct = (Product)productView.SelectedItems[0].Tag;
            textBox_Name.Text = selectedProduct.Name;
            textBox_Notes.Text = selectedProduct.Note;
            checkBox_IsSplitting.Checked = selectedProduct.IsSplitting;

            if (!checkBox_IsSplitting.Checked)
                return;

            numericUpDown_Splitting.Value = selectedProduct.Splitting;
            comboBox_Measurement.SelectedItem = selectedProduct.Measurement;
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтвердить изменения?", "Изменить", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            ProductsContainer.Instance.Change((Product)productView.SelectedItems[0].Tag, 
                checkBox_IsSplitting.Checked ? 
                new Product(
                    textBox_Name.Text, 
                    textBox_Notes.Text, 
                    numericUpDown_Splitting.Value, 
                    (Measurement)comboBox_Measurement.SelectedItem) :
                new Product(textBox_Name.Text, textBox_Notes.Text));

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
