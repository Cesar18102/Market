namespace Market
{
    partial class Storage
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
            this.DealList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DealList)).BeginInit();
            this.SuspendLayout();
            // 
            // DealList
            // 
            this.DealList.AllowUserToAddRows = false;
            this.DealList.AllowUserToDeleteRows = false;
            this.DealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DealList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DealList.Location = new System.Drawing.Point(0, 0);
            this.DealList.Margin = new System.Windows.Forms.Padding(6);
            this.DealList.Name = "DealList";
            this.DealList.ReadOnly = true;
            this.DealList.RowHeadersVisible = false;
            this.DealList.Size = new System.Drawing.Size(365, 502);
            this.DealList.TabIndex = 6;
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 502);
            this.Controls.Add(this.DealList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage";
            ((System.ComponentModel.ISupportInitialize)(this.DealList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DealList;
    }
}