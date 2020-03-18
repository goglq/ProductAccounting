using ProductAccounting.Data.WriteOffs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductAccounting.WriteOffs
{
    public partial class WriteOffsForm : Form
    {
        private IReadOnlyDictionary<Button, Form> dialogs;

        public WriteOffsForm()
        {
            InitializeComponent();

            dialogs = new Dictionary<Button, Form>()
            {
                { button_Add, new CreateWriteOffsForm() },
                { button_Change, new ChangeWriteOffsForm(listView_WriteOffs) },
            };
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Button)sender == button_Change && listView_WriteOffs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите списание, которое будет отредактирово!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DialogResult.Cancel == dialogs[(Button)sender].ShowDialog())
                return;

            FillListView();
        }

        private void FillListView()
        {
            listView_WriteOffs.Items.Clear();
            WriteOffsContainer.Instance.WriteOffs.ToList().ForEach(product => AddProductToListView(product));
        }

        private void AddProductToListView(WriteOff writeOff)
        {
            ListViewItem item = new ListViewItem(writeOff.Date.ToShortDateString());
            item.SubItems.Add(writeOff.Master);
            item.SubItems.Add(writeOff.ToString());
            item.Tag = writeOff;
            listView_WriteOffs.Items.Add(item);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show($"Удалить товар: ", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                return;
            if (!(listView_WriteOffs.SelectedItems[0].Tag is WriteOff))
                throw new ArgumentException("Ошибка! Передана переменная неправильного типа");

            WriteOffsContainer.Instance.Delete((WriteOff)listView_WriteOffs.SelectedItems[0].Tag);
            FillListView();
        }

        private void WriteOffsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!WriteOffsContainer.Instance.IsChanged)
                return;

            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    WriteOffsContainer.Instance.Save();
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
