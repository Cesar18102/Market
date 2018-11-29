namespace Market
{
    partial class ProductForm
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
            this.ProductList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductSection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.DelId = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelId)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.AllowUserToAddRows = false;
            this.ProductList.AllowUserToDeleteRows = false;
            this.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductList.Location = new System.Drawing.Point(0, 0);
            this.ProductList.Margin = new System.Windows.Forms.Padding(6);
            this.ProductList.Name = "ProductList";
            this.ProductList.ReadOnly = true;
            this.ProductList.RowHeadersVisible = false;
            this.ProductList.Size = new System.Drawing.Size(842, 305);
            this.ProductList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProductSection);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddProduct);
            this.panel1.Controls.Add(this.ProductPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProductDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 262);
            this.panel1.TabIndex = 1;
            // 
            // ProductSection
            // 
            this.ProductSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductSection.FormattingEnabled = true;
            this.ProductSection.Location = new System.Drawing.Point(121, 44);
            this.ProductSection.Name = "ProductSection";
            this.ProductSection.Size = new System.Drawing.Size(329, 32);
            this.ProductSection.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отдел: ";
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(12, 212);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(438, 42);
            this.AddProduct.TabIndex = 5;
            this.AddProduct.Text = "Добавить продукт";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProductPrice
            // 
            this.ProductPrice.DecimalPlaces = 2;
            this.ProductPrice.Location = new System.Drawing.Point(121, 177);
            this.ProductPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ProductPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(329, 29);
            this.ProductPrice.TabIndex = 4;
            this.ProductPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена: ";
            // 
            // ProductDescription
            // 
            this.ProductDescription.Location = new System.Drawing.Point(121, 82);
            this.ProductDescription.MaxLength = 512;
            this.ProductDescription.Multiline = true;
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Size = new System.Drawing.Size(329, 88);
            this.ProductDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание: ";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(121, 9);
            this.ProductName.MaxLength = 100;
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(329, 29);
            this.ProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveProduct);
            this.panel2.Controls.Add(this.DelId);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(459, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 262);
            this.panel2.TabIndex = 2;
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.Location = new System.Drawing.Point(3, 47);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Size = new System.Drawing.Size(368, 207);
            this.RemoveProduct.TabIndex = 7;
            this.RemoveProduct.Text = "Удалить продукт";
            this.RemoveProduct.UseVisualStyleBackColor = true;
            this.RemoveProduct.Click += new System.EventHandler(this.RemoveProduct_Click);
            // 
            // DelId
            // 
            this.DelId.Location = new System.Drawing.Point(48, 9);
            this.DelId.Name = "DelId";
            this.DelId.Size = new System.Drawing.Size(323, 29);
            this.DelId.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(5, 11);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(37, 24);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID: ";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 567);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.NumericUpDown ProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveProduct;
        private System.Windows.Forms.NumericUpDown DelId;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox ProductSection;
        private System.Windows.Forms.Label label4;
    }
}