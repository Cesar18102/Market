namespace Market
{
    partial class SupplyForm
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
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Provider = new System.Windows.Forms.ComboBox();
            this.Product = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddSupply = new System.Windows.Forms.Button();
            this.SupplyList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.Amount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Provider);
            this.panel1.Controls.Add(this.Product);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddSupply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 233);
            this.panel1.TabIndex = 4;
            // 
            // Price
            // 
            this.Price.DecimalPlaces = 2;
            this.Price.Location = new System.Drawing.Point(192, 114);
            this.Price.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(499, 29);
            this.Price.TabIndex = 4;
            this.Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(193, 149);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(499, 29);
            this.Date.TabIndex = 5;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(192, 79);
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
            this.Amount.TabIndex = 3;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Стоимость: ";
            // 
            // Provider
            // 
            this.Provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Provider.FormattingEnabled = true;
            this.Provider.Location = new System.Drawing.Point(192, 41);
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(499, 32);
            this.Provider.TabIndex = 2;
            // 
            // Product
            // 
            this.Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Product.FormattingEnabled = true;
            this.Product.Location = new System.Drawing.Point(192, 3);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(499, 32);
            this.Product.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Поставщик: ";
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
            // AddSupply
            // 
            this.AddSupply.Location = new System.Drawing.Point(12, 184);
            this.AddSupply.Name = "AddSupply";
            this.AddSupply.Size = new System.Drawing.Size(680, 42);
            this.AddSupply.TabIndex = 6;
            this.AddSupply.Text = "Добавить поставку";
            this.AddSupply.UseVisualStyleBackColor = true;
            this.AddSupply.Click += new System.EventHandler(this.AddSupply_Click);
            // 
            // SupplyList
            // 
            this.SupplyList.AllowUserToAddRows = false;
            this.SupplyList.AllowUserToDeleteRows = false;
            this.SupplyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplyList.Location = new System.Drawing.Point(0, 0);
            this.SupplyList.Margin = new System.Windows.Forms.Padding(6);
            this.SupplyList.Name = "SupplyList";
            this.SupplyList.ReadOnly = true;
            this.SupplyList.RowHeadersVisible = false;
            this.SupplyList.Size = new System.Drawing.Size(703, 305);
            this.SupplyList.TabIndex = 3;
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SupplyList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SupplyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.NumericUpDown Amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Provider;
        private System.Windows.Forms.ComboBox Product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSupply;
        private System.Windows.Forms.DataGridView SupplyList;

    }
}