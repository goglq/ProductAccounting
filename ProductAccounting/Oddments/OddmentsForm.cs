using ProductAccounting.Data.Oddments;
using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAccounting.Oddments
{
    public partial class OddmentsForm : Form
    {
        public OddmentsForm()
        {
            InitializeComponent();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OddmentsForm_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void RefreshListView()
        {
            listView_Oddments.Items.Clear();
            OddmentsContainer.Instance.Oddments.ToList().ForEach(oddment => AddOddmentToListView(oddment));
        }

        private void AddOddmentToListView(Oddment oddment)
        {
            ListViewItem item = new ListViewItem(oddment.Product.Name);
            item.SubItems.Add(oddment.ProductQuantityLeft.ToString());
            item.SubItems.Add(oddment.Product.IsSplitting ? oddment.ProductSplittingLeft.ToString() : "...");
            item.Tag = oddment;
            listView_Oddments.Items.Add(item);
        }
    }
}
