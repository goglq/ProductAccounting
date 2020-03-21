using ProductAccounting.Data.Procurements;
using ProductAccounting.Data.Products;
using ProductAccounting.Data.WriteOffs;
using ProductAccounting.Oddments;
using ProductAccounting.Procurements;
using ProductAccounting.Products;
using ProductAccounting.WriteOffs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAccounting
{
    public partial class MenuForm : Form
    {
        private static IReadOnlyList<Form> forms = new Form[] {
            new ProductsForm(),
            new ProcurementForm(),
            new WriteOffsForm(),
            new OddmentsForm(),
            new InventoryForm()
        };

        public MenuForm()
        {
            InitializeComponent();

            ProductsContainer.Instance.Load();
            ProcurementsContainer.Instance.Load();
            WriteOffsContainer.Instance.Load();

            button_Products.Tag = 0;
            button_Procurement.Tag = 1;
            button_WriteOffs.Tag = 2;
            button_Oddments.Tag = 3;
            button_Inventory.Tag = 4;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Hide();
            forms[(int)button.Tag].ShowDialog();
            Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
