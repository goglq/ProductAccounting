using ProductAccounting.Data.Procurements;
using ProductAccounting.Data.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProductAccounting.Procurements
{
    public partial class ProcurementForm : Form
    {
        private IReadOnlyDictionary<Button, Form> dialogs;

        public ProcurementForm()
        {
            InitializeComponent();
            dialogs = new Dictionary<Button, Form>()
            {
                {button_Add, new CreateProcurementForm()},
                {button_Change, new ChangeProcurementForm(listView_Procurements)}
            };
        }

        private void ProcurementForm_Load(object sender, EventArgs e)
        {
            ProcurementsContainer.Instance.Load();
            RefreshListView();
        }

        private void Button_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((Button)sender == button_Change && listView_Procurements.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите продукт, который будет отредактирован!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DialogResult.Cancel == dialogs[(Button)sender].ShowDialog())
                return;

            RefreshListView();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Procurement selectedProcurement = listView_Procurements.SelectedItems[0].Tag as Procurement;
            if (selectedProcurement is null)
            {
                MessageBox.Show("Выберите элемент, который вы хотите удалить!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcurementsContainer.Instance.Delete(selectedProcurement);
            RefreshListView();
        }

        private void RefreshListView()
        {
            listView_Procurements.Items.Clear();
            ProcurementsContainer.Instance.Procurements.ToList().ForEach(procurement => AddProcurementToListView(procurement));
        }

        private void AddProcurementToListView(Procurement procurement)
        {
            ListViewItem item = new ListViewItem(procurement.PaymentDate.ToShortDateString());
            item.SubItems.Add(procurement.IsRecieved ? procurement.RecieveDate.ToShortDateString() : "");
            item.SubItems.Add(procurement.ToString());
            item.SubItems.Add(procurement.TotalPrice.ToString());
            item.Tag = procurement;
            listView_Procurements.Items.Add(item);
        }

        private void ProcurementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ProcurementsContainer.Instance.IsChanged)
                return;

            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    ProcurementsContainer.Instance.Save();
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
