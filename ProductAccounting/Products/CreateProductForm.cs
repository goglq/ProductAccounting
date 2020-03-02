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
    public partial class CreateProductForm : Form
    {
        public CreateProductForm()
        {
            InitializeComponent();
            Refresh();

            Measurement[] measurement = (Measurement[])Enum.GetValues(typeof(Measurement));
            measurement.ToList().ForEach(m => comboBox_Measurement.Items.Add(m));
        }

        private void Refresh()
        {
            textBox_Name.Text = "\0";
            textBox_Notes.Text = "\0";

            checkBox_IsSplitting.Checked = false;
            numericUpDown_Splitting.Enabled = checkBox_IsSplitting.Checked;
            numericUpDown_Splitting.Value = 0;

            comboBox_Measurement.Enabled = checkBox_IsSplitting.Checked;
            comboBox_Measurement.SelectedItem = null;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (IsError("Название товара не заполнено", string.IsNullOrWhiteSpace(textBox_Name.Text)) || 
                IsError("Выберите единицу измерения", checkBox_IsSplitting.Checked && comboBox_Measurement.SelectedItem == null))
                return;

            if (checkBox_IsSplitting.Checked)
                AddSplittingProduct();
            else
                AddNotSplittingProduct();

            DialogResult = DialogResult.OK;
            Refresh();
            Close();
        }

        private void AddNotSplittingProduct() =>
            ProductsContainer.Instance.Add(new Product(
                textBox_Name.Text,
                textBox_Notes.Text));

        private void AddSplittingProduct() => ProductsContainer.Instance.Add(new Product(
                textBox_Name.Text,
                textBox_Notes.Text,
                numericUpDown_Splitting.Value,
                (Measurement)comboBox_Measurement.SelectedItem));

        private void checkBox_IsSplitting_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_Splitting.Enabled = checkBox_IsSplitting.Checked;
            comboBox_Measurement.Enabled = checkBox_IsSplitting.Checked;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool IsError(string error, bool condition)
        {
            if (!condition)
                return false;
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }
    }
}
