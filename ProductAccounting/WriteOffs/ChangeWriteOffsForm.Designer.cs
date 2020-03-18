namespace ProductAccounting.WriteOffs
{
    partial class ChangeWriteOffsForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_measurement = new System.Windows.Forms.Label();
            this.numericUpDown_used = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_saveExit = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_products = new System.Windows.Forms.ListView();
            this.columnHeader_product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_master = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_writeOffDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_used)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(-3, -4);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(810, 469);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_measurement);
            this.panel2.Controls.Add(this.numericUpDown_used);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button_saveExit);
            this.panel2.Controls.Add(this.button_remove);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.comboBox_product);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(587, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 465);
            this.panel2.TabIndex = 1;
            // 
            // label_measurement
            // 
            this.label_measurement.AutoSize = true;
            this.label_measurement.Location = new System.Drawing.Point(128, 136);
            this.label_measurement.Name = "label_measurement";
            this.label_measurement.Size = new System.Drawing.Size(35, 13);
            this.label_measurement.TabIndex = 11;
            this.label_measurement.Text = "label3";
            // 
            // numericUpDown_used
            // 
            this.numericUpDown_used.Location = new System.Drawing.Point(8, 136);
            this.numericUpDown_used.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_used.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown_used.Name = "numericUpDown_used";
            this.numericUpDown_used.Size = new System.Drawing.Size(111, 20);
            this.numericUpDown_used.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Израсходовано";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 48);
            this.label6.TabIndex = 7;
            this.label6.Text = "Добавить списанный товар";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Товар";
            // 
            // button_saveExit
            // 
            this.button_saveExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_saveExit.Location = new System.Drawing.Point(10, 399);
            this.button_saveExit.Margin = new System.Windows.Forms.Padding(2);
            this.button_saveExit.Name = "button_saveExit";
            this.button_saveExit.Size = new System.Drawing.Size(198, 51);
            this.button_saveExit.TabIndex = 4;
            this.button_saveExit.Text = "Сохранить и выйти";
            this.button_saveExit.UseVisualStyleBackColor = true;
            this.button_saveExit.Click += new System.EventHandler(this.Button_saveExit_Click);
            // 
            // button_remove
            // 
            this.button_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_remove.Location = new System.Drawing.Point(8, 256);
            this.button_remove.Margin = new System.Windows.Forms.Padding(2);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(198, 49);
            this.button_remove.TabIndex = 3;
            this.button_remove.Text = "Удалить";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.Button_remove_Click);
            // 
            // button_add
            // 
            this.button_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add.Location = new System.Drawing.Point(8, 200);
            this.button_add.Margin = new System.Windows.Forms.Padding(2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(198, 49);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // comboBox_product
            // 
            this.comboBox_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_product.FormattingEnabled = true;
            this.comboBox_product.Location = new System.Drawing.Point(96, 88);
            this.comboBox_product.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(112, 21);
            this.comboBox_product.TabIndex = 0;
            this.comboBox_product.SelectedValueChanged += new System.EventHandler(this.ComboBox_product_SelectedValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 465);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listView_products);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 381);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Состав";
            // 
            // listView_products
            // 
            this.listView_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_product,
            this.columnHeader_amount});
            this.listView_products.FullRowSelect = true;
            this.listView_products.HideSelection = false;
            this.listView_products.Location = new System.Drawing.Point(56, 16);
            this.listView_products.Margin = new System.Windows.Forms.Padding(2);
            this.listView_products.Name = "listView_products";
            this.listView_products.Size = new System.Drawing.Size(516, 355);
            this.listView_products.TabIndex = 0;
            this.listView_products.UseCompatibleStateImageBehavior = false;
            this.listView_products.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_product
            // 
            this.columnHeader_product.Text = "Продукт";
            this.columnHeader_product.Width = 335;
            // 
            // columnHeader_amount
            // 
            this.columnHeader_amount.Text = "Израсходовано";
            this.columnHeader_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader_amount.Width = 129;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_master);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dateTimePicker_writeOffDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 387);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 76);
            this.panel3.TabIndex = 1;
            // 
            // textBox_master
            // 
            this.textBox_master.Location = new System.Drawing.Point(88, 8);
            this.textBox_master.Name = "textBox_master";
            this.textBox_master.Size = new System.Drawing.Size(480, 20);
            this.textBox_master.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя мастера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата";
            // 
            // dateTimePicker_writeOffDate
            // 
            this.dateTimePicker_writeOffDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_writeOffDate.Location = new System.Drawing.Point(88, 40);
            this.dateTimePicker_writeOffDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_writeOffDate.Name = "dateTimePicker_writeOffDate";
            this.dateTimePicker_writeOffDate.Size = new System.Drawing.Size(477, 20);
            this.dateTimePicker_writeOffDate.TabIndex = 1;
            // 
            // ChangeWriteOffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ChangeWriteOffsForm";
            this.Text = "Изменить списание";
            this.Load += new System.EventHandler(this.ChangeWriteOffForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_used)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown_used;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_saveExit;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_products;
        private System.Windows.Forms.ColumnHeader columnHeader_product;
        private System.Windows.Forms.ColumnHeader columnHeader_amount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_writeOffDate;
        private System.Windows.Forms.Label label_measurement;
        private System.Windows.Forms.TextBox textBox_master;
        private System.Windows.Forms.Label label3;
    }
}