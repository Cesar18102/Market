namespace Market
{
    partial class Form1
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
            this.Worker = new System.Windows.Forms.Button();
            this.Provider = new System.Windows.Forms.Button();
            this.Supply = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.Section = new System.Windows.Forms.Button();
            this.Post = new System.Windows.Forms.Button();
            this.Deal = new System.Windows.Forms.Button();
            this.Storage = new System.Windows.Forms.Button();
            this.Summary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Worker
            // 
            this.Worker.Location = new System.Drawing.Point(12, 12);
            this.Worker.Name = "Worker";
            this.Worker.Size = new System.Drawing.Size(367, 46);
            this.Worker.TabIndex = 0;
            this.Worker.Text = "Нанять/Уволить работника";
            this.Worker.UseVisualStyleBackColor = true;
            this.Worker.Click += new System.EventHandler(this.Worker_Click);
            // 
            // Provider
            // 
            this.Provider.Location = new System.Drawing.Point(12, 168);
            this.Provider.Name = "Provider";
            this.Provider.Size = new System.Drawing.Size(367, 46);
            this.Provider.TabIndex = 3;
            this.Provider.Text = "Регистрация/Удаление поставщика";
            this.Provider.UseVisualStyleBackColor = true;
            this.Provider.Click += new System.EventHandler(this.Provider_Click);
            // 
            // Supply
            // 
            this.Supply.Location = new System.Drawing.Point(12, 220);
            this.Supply.Name = "Supply";
            this.Supply.Size = new System.Drawing.Size(367, 46);
            this.Supply.TabIndex = 4;
            this.Supply.Text = "Регистрация поставки";
            this.Supply.UseVisualStyleBackColor = true;
            this.Supply.Click += new System.EventHandler(this.Supply_Click);
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(12, 324);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(367, 46);
            this.Product.TabIndex = 6;
            this.Product.Text = "Добавить/Удалить товар";
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Section
            // 
            this.Section.Location = new System.Drawing.Point(12, 64);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(367, 46);
            this.Section.TabIndex = 1;
            this.Section.Text = "Добавить/Удалить отдел";
            this.Section.UseVisualStyleBackColor = true;
            this.Section.Click += new System.EventHandler(this.Section_Click);
            // 
            // Post
            // 
            this.Post.Location = new System.Drawing.Point(12, 116);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(367, 46);
            this.Post.TabIndex = 2;
            this.Post.Text = "Учредить/Упразднить должность";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // Deal
            // 
            this.Deal.Location = new System.Drawing.Point(12, 272);
            this.Deal.Name = "Deal";
            this.Deal.Size = new System.Drawing.Size(367, 46);
            this.Deal.TabIndex = 5;
            this.Deal.Text = "Регистрация покупки";
            this.Deal.UseVisualStyleBackColor = true;
            this.Deal.Click += new System.EventHandler(this.Deal_Click);
            // 
            // Storage
            // 
            this.Storage.Location = new System.Drawing.Point(12, 376);
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(367, 46);
            this.Storage.TabIndex = 7;
            this.Storage.Text = "Склад";
            this.Storage.UseVisualStyleBackColor = true;
            this.Storage.Click += new System.EventHandler(this.Storage_Click);
            // 
            // Summary
            // 
            this.Summary.Location = new System.Drawing.Point(12, 428);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(367, 46);
            this.Summary.TabIndex = 8;
            this.Summary.Text = "Итоги";
            this.Summary.UseVisualStyleBackColor = true;
            this.Summary.Click += new System.EventHandler(this.Summary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 482);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Deal);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Supply);
            this.Controls.Add(this.Provider);
            this.Controls.Add(this.Worker);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Worker;
        private System.Windows.Forms.Button Provider;
        private System.Windows.Forms.Button Supply;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button Section;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.Button Deal;
        private System.Windows.Forms.Button Storage;
        private System.Windows.Forms.Button Summary;
    }
}

