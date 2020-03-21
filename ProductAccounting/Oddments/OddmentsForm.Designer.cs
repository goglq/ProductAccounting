namespace ProductAccounting.Oddments
{
    partial class OddmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView_Oddments = new System.Windows.Forms.ListView();
            this.columnProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOddmentPiece = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOddmentN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel = new System.Windows.Forms.Panel();
            this.button_Menu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.listView_Oddments, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 286);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // listView_Oddments
            // 
            this.listView_Oddments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProduct,
            this.columnOddmentPiece,
            this.columnOddmentN});
            this.listView_Oddments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Oddments.GridLines = true;
            this.listView_Oddments.HideSelection = false;
            this.listView_Oddments.Location = new System.Drawing.Point(3, 10);
            this.listView_Oddments.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.listView_Oddments.Name = "listView_Oddments";
            this.listView_Oddments.Size = new System.Drawing.Size(481, 273);
            this.listView_Oddments.TabIndex = 1;
            this.listView_Oddments.UseCompatibleStateImageBehavior = false;
            this.listView_Oddments.View = System.Windows.Forms.View.Details;
            // 
            // columnProduct
            // 
            this.columnProduct.Text = "Товар";
            this.columnProduct.Width = 200;
            // 
            // columnOddmentPiece
            // 
            this.columnOddmentPiece.Text = "Остаток, шт";
            this.columnOddmentPiece.Width = 100;
            // 
            // columnOddmentN
            // 
            this.columnOddmentN.Text = "Остаток, г/мл";
            this.columnOddmentN.Width = 100;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel.Controls.Add(this.button_Menu);
            this.panel.Location = new System.Drawing.Point(490, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(144, 280);
            this.panel.TabIndex = 2;
            // 
            // button_Menu
            // 
            this.button_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Menu.Location = new System.Drawing.Point(8, 218);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(128, 56);
            this.button_Menu.TabIndex = 3;
            this.button_Menu.Text = "Главное меню";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // OddmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 288);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(653, 327);
            this.Name = "OddmentsForm";
            this.Text = "Остатки товаров";
            this.Load += new System.EventHandler(this.OddmentsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView_Oddments;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.ColumnHeader columnProduct;
        private System.Windows.Forms.ColumnHeader columnOddmentPiece;
        private System.Windows.Forms.ColumnHeader columnOddmentN;
    }
}