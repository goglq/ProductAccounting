using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAccounting.Procurements
{
    public partial class ProcurementForm : Form
    {
        public ProcurementForm()
        {
            InitializeComponent();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
