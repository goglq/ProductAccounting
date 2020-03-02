namespace ProductAccounting
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Inventory = new System.Windows.Forms.Button();
            this.button_Oddments = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Procurement = new System.Windows.Forms.Button();
            this.button_WriteOffs = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(3, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(292, 54);
            this.button4.TabIndex = 2;
            this.button4.Text = "Остатки";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_Inventory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Oddments, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Products, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Exit, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.86793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.86793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.86793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.86793F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.660378F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.86793F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_Inventory
            // 
            this.button_Inventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Inventory.Location = new System.Drawing.Point(3, 183);
            this.button_Inventory.Name = "button_Inventory";
            this.button_Inventory.Size = new System.Drawing.Size(290, 54);
            this.button_Inventory.TabIndex = 3;
            this.button_Inventory.Text = "Инвентаризация";
            this.button_Inventory.UseVisualStyleBackColor = true;
            this.button_Inventory.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Oddments
            // 
            this.button_Oddments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Oddments.Location = new System.Drawing.Point(3, 123);
            this.button_Oddments.Name = "button_Oddments";
            this.button_Oddments.Size = new System.Drawing.Size(290, 54);
            this.button_Oddments.TabIndex = 2;
            this.button_Oddments.Text = "Остатки";
            this.button_Oddments.UseVisualStyleBackColor = true;
            this.button_Oddments.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Products
            // 
            this.button_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Products.Location = new System.Drawing.Point(3, 5);
            this.button_Products.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(290, 52);
            this.button_Products.TabIndex = 0;
            this.button_Products.Text = "Товары";
            this.button_Products.UseVisualStyleBackColor = true;
            this.button_Products.Click += new System.EventHandler(this.button_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.Location = new System.Drawing.Point(3, 261);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(290, 56);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button_Procurement, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_WriteOffs, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 54);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // button_Procurement
            // 
            this.button_Procurement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Procurement.Location = new System.Drawing.Point(3, 3);
            this.button_Procurement.Name = "button_Procurement";
            this.button_Procurement.Size = new System.Drawing.Size(139, 48);
            this.button_Procurement.TabIndex = 1;
            this.button_Procurement.Text = "Закупки";
            this.button_Procurement.UseVisualStyleBackColor = true;
            this.button_Procurement.Click += new System.EventHandler(this.button_Click);
            // 
            // button_WriteOffs
            // 
            this.button_WriteOffs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_WriteOffs.Location = new System.Drawing.Point(148, 3);
            this.button_WriteOffs.Name = "button_WriteOffs";
            this.button_WriteOffs.Size = new System.Drawing.Size(139, 48);
            this.button_WriteOffs.TabIndex = 0;
            this.button_WriteOffs.Text = "Списания";
            this.button_WriteOffs.UseVisualStyleBackColor = true;
            this.button_WriteOffs.Click += new System.EventHandler(this.button_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 317);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(310, 356);
            this.Name = "MenuForm";
            this.Text = "Меню";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_Inventory;
        private System.Windows.Forms.Button button_Oddments;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Procurement;
        private System.Windows.Forms.Button button_WriteOffs;
    }
}

