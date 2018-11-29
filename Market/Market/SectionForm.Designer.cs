namespace Market
{
    partial class SectionForm
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
            this.SectionList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Manager = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddSection = new System.Windows.Forms.Button();
            this.SectionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveSection = new System.Windows.Forms.Button();
            this.DelID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SectionList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionList
            // 
            this.SectionList.AllowUserToAddRows = false;
            this.SectionList.AllowUserToDeleteRows = false;
            this.SectionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SectionList.Dock = System.Windows.Forms.DockStyle.Top;
            this.SectionList.Location = new System.Drawing.Point(0, 0);
            this.SectionList.Margin = new System.Windows.Forms.Padding(6);
            this.SectionList.Name = "SectionList";
            this.SectionList.ReadOnly = true;
            this.SectionList.RowHeadersVisible = false;
            this.SectionList.Size = new System.Drawing.Size(582, 269);
            this.SectionList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Manager);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddSection);
            this.panel1.Controls.Add(this.SectionName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 125);
            this.panel1.TabIndex = 1;
            // 
            // Manager
            // 
            this.Manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Manager.FormattingEnabled = true;
            this.Manager.Location = new System.Drawing.Point(153, 38);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(205, 32);
            this.Manager.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Заведующий: ";
            // 
            // AddSection
            // 
            this.AddSection.Location = new System.Drawing.Point(16, 76);
            this.AddSection.Name = "AddSection";
            this.AddSection.Size = new System.Drawing.Size(342, 41);
            this.AddSection.TabIndex = 3;
            this.AddSection.Text = "Добавить отдел";
            this.AddSection.UseVisualStyleBackColor = true;
            this.AddSection.Click += new System.EventHandler(this.AddSection_Click);
            // 
            // SectionName
            // 
            this.SectionName.Location = new System.Drawing.Point(153, 3);
            this.SectionName.MaxLength = 16;
            this.SectionName.Name = "SectionName";
            this.SectionName.Size = new System.Drawing.Size(205, 29);
            this.SectionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveSection);
            this.panel2.Controls.Add(this.DelID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(373, 269);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 125);
            this.panel2.TabIndex = 2;
            // 
            // RemoveSection
            // 
            this.RemoveSection.Location = new System.Drawing.Point(7, 38);
            this.RemoveSection.Name = "RemoveSection";
            this.RemoveSection.Size = new System.Drawing.Size(194, 84);
            this.RemoveSection.TabIndex = 5;
            this.RemoveSection.Text = "Удалить отдел";
            this.RemoveSection.UseVisualStyleBackColor = true;
            this.RemoveSection.Click += new System.EventHandler(this.RemoveSection_Click);
            // 
            // DelID
            // 
            this.DelID.Location = new System.Drawing.Point(46, 3);
            this.DelID.Name = "DelID";
            this.DelID.Size = new System.Drawing.Size(155, 29);
            this.DelID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID: ";
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 394);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SectionList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.SectionList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SectionList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddSection;
        private System.Windows.Forms.TextBox SectionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveSection;
        private System.Windows.Forms.NumericUpDown DelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Manager;
        private System.Windows.Forms.Label label3;
    }
}