namespace ProductAccounting.Products
{
    partial class ProductsForm
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
            this.listView_Products = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSplitting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMeasure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel = new System.Windows.Forms.Panel();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.listView_Products, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 286);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listView_Products
            // 
            this.listView_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnNotes,
            this.columnSplitting,
            this.columnMeasure,
            this.columnCount});
            this.listView_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Products.FullRowSelect = true;
            this.listView_Products.GridLines = true;
            this.listView_Products.HideSelection = false;
            this.listView_Products.Location = new System.Drawing.Point(3, 10);
            this.listView_Products.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.listView_Products.Name = "listView_Products";
            this.listView_Products.Size = new System.Drawing.Size(484, 273);
            this.listView_Products.TabIndex = 1;
            this.listView_Products.UseCompatibleStateImageBehavior = false;
            this.listView_Products.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Название";
            this.columnName.Width = 100;
            // 
            // columnNotes
            // 
            this.columnNotes.Text = "Заметки";
            this.columnNotes.Width = 200;
            // 
            // columnSplitting
            // 
            this.columnSplitting.Text = "Дробление";
            // 
            // columnMeasure
            // 
            this.columnMeasure.Text = "Единица измерения";
            // 
            // columnCount
            // 
            this.columnCount.Text = "Количество";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel.Controls.Add(this.button_Menu);
            this.panel.Controls.Add(this.button_Delete);
            this.panel.Controls.Add(this.button_Change);
            this.panel.Controls.Add(this.button_Add);
            this.panel.Location = new System.Drawing.Point(493, 3);
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
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(8, 136);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(128, 56);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(8, 72);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(128, 56);
            this.button_Change.TabIndex = 1;
            this.button_Change.Text = "Изменить";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(8, 8);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(128, 56);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 288);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(656, 327);
            this.Name = "ProductsForm";
            this.Text = "Товары";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView_Products;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnNotes;
        private System.Windows.Forms.ColumnHeader columnSplitting;
        private System.Windows.Forms.ColumnHeader columnMeasure;
        private System.Windows.Forms.ColumnHeader columnCount;
    }
}