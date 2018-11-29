namespace Market
{
    partial class DealForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PeriodCB = new System.Windows.Forms.CheckBox();
            this.ProductCB = new System.Windows.Forms.CheckBox();
            this.EndVAL = new System.Windows.Forms.DateTimePicker();
            this.StartVAL = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductVAL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.Product = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDeal = new System.Windows.Forms.Button();
            this.DealList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PeriodCB);
            this.panel1.Controls.Add(this.ProductCB);
            this.panel1.Controls.Add(this.EndVAL);
            this.panel1.Controls.Add(this.StartVAL);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ProductVAL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.Product);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddDeal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 262);
            this.panel1.TabIndex = 6;
            // 
            // PeriodCB
            // 
            this.PeriodCB.AutoSize = true;
            this.PeriodCB.Location = new System.Drawing.Point(331, 201);
            this.PeriodCB.Name = "PeriodCB";
            this.PeriodCB.Size = new System.Drawing.Size(108, 28);
            this.PeriodCB.TabIndex = 20;
            this.PeriodCB.Text = "Период: ";
            this.PeriodCB.UseVisualStyleBackColor = true;
            this.PeriodCB.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // ProductCB
            // 
            this.ProductCB.AutoSize = true;
            this.ProductCB.Location = new System.Drawing.Point(12, 203);
            this.ProductCB.Name = "ProductCB";
            this.ProductCB.Size = new System.Drawing.Size(114, 28);
            this.ProductCB.TabIndex = 19;
            this.ProductCB.Text = "Продукт: ";
            this.ProductCB.UseVisualStyleBackColor = true;
            this.ProductCB.CheckedChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // EndVAL
            // 
            this.EndVAL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndVAL.Location = new System.Drawing.Point(491, 224);
            this.EndVAL.Name = "EndVAL";
            this.EndVAL.Size = new System.Drawing.Size(200, 29);
            this.EndVAL.TabIndex = 18;
            this.EndVAL.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // StartVAL
            // 
            this.StartVAL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartVAL.Location = new System.Drawing.Point(491, 176);
            this.StartVAL.Name = "StartVAL";
            this.StartVAL.Size = new System.Drawing.Size(200, 29);
            this.StartVAL.TabIndex = 17;
            this.StartVAL.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "По: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "С: ";
            // 
            // ProductVAL
            // 
            this.ProductVAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductVAL.FormattingEnabled = true;
            this.ProductVAL.Location = new System.Drawing.Point(132, 201);
            this.ProductVAL.Name = "ProductVAL";
            this.ProductVAL.Size = new System.Drawing.Size(170, 32);
            this.ProductVAL.TabIndex = 14;
            this.ProductVAL.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фильтры: ";
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(193, 76);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(499, 29);
            this.Date.TabIndex = 3;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(192, 41);
            this.Amount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(499, 29);
            this.Amount.TabIndex = 2;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Product
            // 
            this.Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(192, 3);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(499, 32);
            this.Product.TabIndex = 1;
            this.Product.SelectedIndexChanged += new System.EventHandler(this.Product_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Продукт: ";
            // 
            // AddDeal
            // 
            this.AddDeal.Location = new System.Drawing.Point(12, 111);
            this.AddDeal.Name = "AddDeal";
            this.AddDeal.Size = new System.Drawing.Size(680, 42);
            this.AddDeal.TabIndex = 4;
            this.AddDeal.Text = "Добавить покупку";
            this.AddDeal.UseVisualStyleBackColor = true;
            this.AddDeal.Click += new System.EventHandler(this.AddDeal_Click);
            // 
            // DealList
            // 
            this.DealList.AllowUserToAddRows = false;
            this.DealList.AllowUserToDeleteRows = false;
            this.DealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DealList.Location = new System.Drawing.Point(0, 0);
            this.DealList.Margin = new System.Windows.Forms.Padding(6);
            this.DealList.Name = "DealList";
            this.DealList.ReadOnly = true;
            this.DealList.RowHeadersVisible = false;
            this.DealList.Size = new System.Drawing.Size(711, 305);
            this.DealList.TabIndex = 5;
            // 
            // DealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DealList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DealForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDeal;
        private System.Windows.Forms.DataGridView DealList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PeriodCB;
        private System.Windows.Forms.CheckBox ProductCB;
        private System.Windows.Forms.DateTimePicker EndVAL;
        private System.Windows.Forms.DateTimePicker StartVAL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ProductVAL;
    }
}