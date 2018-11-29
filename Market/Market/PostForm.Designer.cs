namespace Market
{
    partial class PostForm
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
            this.RemovePost = new System.Windows.Forms.Button();
            this.DelID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPost = new System.Windows.Forms.Button();
            this.PostName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PostList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemovePost);
            this.panel2.Controls.Add(this.DelID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(417, 269);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 86);
            this.panel2.TabIndex = 5;
            // 
            // RemovePost
            // 
            this.RemovePost.Location = new System.Drawing.Point(7, 38);
            this.RemovePost.Name = "RemovePost";
            this.RemovePost.Size = new System.Drawing.Size(260, 41);
            this.RemovePost.TabIndex = 4;
            this.RemovePost.Text = "Упразднить должность";
            this.RemovePost.UseVisualStyleBackColor = true;
            this.RemovePost.Click += new System.EventHandler(this.RemovePost_Click);
            // 
            // DelID
            // 
            this.DelID.Location = new System.Drawing.Point(46, 3);
            this.DelID.Name = "DelID";
            this.DelID.Size = new System.Drawing.Size(221, 29);
            this.DelID.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.AddPost);
            this.panel1.Controls.Add(this.PostName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 86);
            this.panel1.TabIndex = 4;
            // 
            // AddPost
            // 
            this.AddPost.Location = new System.Drawing.Point(16, 38);
            this.AddPost.Name = "AddPost";
            this.AddPost.Size = new System.Drawing.Size(392, 41);
            this.AddPost.TabIndex = 2;
            this.AddPost.Text = "Учредить должность";
            this.AddPost.UseVisualStyleBackColor = true;
            this.AddPost.Click += new System.EventHandler(this.AddPost_Click);
            // 
            // PostName
            // 
            this.PostName.Location = new System.Drawing.Point(153, 3);
            this.PostName.MaxLength = 30;
            this.PostName.Name = "PostName";
            this.PostName.Size = new System.Drawing.Size(255, 29);
            this.PostName.TabIndex = 1;
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
            // PostList
            // 
            this.PostList.AllowUserToAddRows = false;
            this.PostList.AllowUserToDeleteRows = false;
            this.PostList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PostList.Location = new System.Drawing.Point(0, 0);
            this.PostList.Margin = new System.Windows.Forms.Padding(6);
            this.PostList.Name = "PostList";
            this.PostList.ReadOnly = true;
            this.PostList.RowHeadersVisible = false;
            this.PostList.Size = new System.Drawing.Size(696, 269);
            this.PostList.TabIndex = 3;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 355);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PostList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button RemovePost;
        private System.Windows.Forms.NumericUpDown DelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddPost;
        private System.Windows.Forms.TextBox PostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PostList;
    }
}