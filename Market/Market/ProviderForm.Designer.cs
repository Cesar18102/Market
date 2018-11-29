namespace Market
{
    partial class ProviderForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveProvider = new System.Windows.Forms.Button();
            this.DelID = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProviderPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProviderAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProvider = new System.Windows.Forms.Button();
            this.ProviderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProviderList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveProvider);
            this.panel2.Controls.Add(this.DelID);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(459, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 162);
            this.panel2.TabIndex = 5;
            // 
            // RemoveProvider
            // 
            this.RemoveProvider.Location = new System.Drawing.Point(3, 47);
            this.RemoveProvider.Name = "RemoveProvider";
            this.RemoveProvider.Size = new System.Drawing.Size(368, 109);
            this.RemoveProvider.TabIndex = 6;
            this.RemoveProvider.Text = "Удалить поставщика";
            this.RemoveProvider.UseVisualStyleBackColor = true;
            this.RemoveProvider.Click += new System.EventHandler(this.RemoveProvider_Click);
            // 
            // DelID
            // 
            this.DelID.Location = new System.Drawing.Point(48, 9);
            this.DelID.Name = "DelID";
            this.DelID.Size = new System.Drawing.Size(323, 29);
            this.DelID.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.ProviderPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProviderAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AddProvider);
            this.panel1.Controls.Add(this.ProviderName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 162);
            this.panel1.TabIndex = 4;
            // 
            // ProviderPhone
            // 
            this.ProviderPhone.Location = new System.Drawing.Point(121, 79);
            this.ProviderPhone.MaxLength = 15;
            this.ProviderPhone.Name = "ProviderPhone";
            this.ProviderPhone.Size = new System.Drawing.Size(329, 29);
            this.ProviderPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Телефон: ";
            // 
            // ProviderAddress
            // 
            this.ProviderAddress.Location = new System.Drawing.Point(121, 44);
            this.ProviderAddress.MaxLength = 100;
            this.ProviderAddress.Name = "ProviderAddress";
            this.ProviderAddress.Size = new System.Drawing.Size(329, 29);
            this.ProviderAddress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Адрес: ";
            // 
            // AddProvider
            // 
            this.AddProvider.Location = new System.Drawing.Point(12, 114);
            this.AddProvider.Name = "AddProvider";
            this.AddProvider.Size = new System.Drawing.Size(438, 42);
            this.AddProvider.TabIndex = 4;
            this.AddProvider.Text = "Добавить поставщика";
            this.AddProvider.UseVisualStyleBackColor = true;
            this.AddProvider.Click += new System.EventHandler(this.AddProvider_Click);
            // 
            // ProviderName
            // 
            this.ProviderName.Location = new System.Drawing.Point(121, 9);
            this.ProviderName.MaxLength = 50;
            this.ProviderName.Name = "ProviderName";
            this.ProviderName.Size = new System.Drawing.Size(329, 29);
            this.ProviderName.TabIndex = 1;
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
            // ProviderList
            // 
            this.ProviderList.AllowUserToAddRows = false;
            this.ProviderList.AllowUserToDeleteRows = false;
            this.ProviderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProviderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProviderList.Location = new System.Drawing.Point(0, 0);
            this.ProviderList.Margin = new System.Windows.Forms.Padding(6);
            this.ProviderList.Name = "ProviderList";
            this.ProviderList.ReadOnly = true;
            this.ProviderList.RowHeadersVisible = false;
            this.ProviderList.Size = new System.Drawing.Size(842, 305);
            this.ProviderList.TabIndex = 3;
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProviderList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProviderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProviderForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RemoveProvider;
        private System.Windows.Forms.NumericUpDown DelID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ProviderPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProviderAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProvider;
        private System.Windows.Forms.TextBox ProviderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProviderList;

    }
}