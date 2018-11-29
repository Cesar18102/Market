namespace Market
{
    partial class WorkerForm
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
            this.FireWorker = new System.Windows.Forms.Button();
            this.DelID = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WorkerSection = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WorkerPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WorkerAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WorkerPost = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WorkerFathername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HireWorker = new System.Windows.Forms.Button();
            this.WorkerSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkerList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FireWorker);
            this.panel2.Controls.Add(this.DelID);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(460, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 311);
            this.panel2.TabIndex = 5;
            // 
            // FireWorker
            // 
            this.FireWorker.Location = new System.Drawing.Point(3, 44);
            this.FireWorker.Name = "FireWorker";
            this.FireWorker.Size = new System.Drawing.Size(368, 258);
            this.FireWorker.TabIndex = 10;
            this.FireWorker.Text = "Уволить сотрудника";
            this.FireWorker.UseVisualStyleBackColor = true;
            this.FireWorker.Click += new System.EventHandler(this.FireWorker_Click);
            // 
            // DelID
            // 
            this.DelID.Location = new System.Drawing.Point(48, 9);
            this.DelID.Name = "DelID";
            this.DelID.Size = new System.Drawing.Size(323, 29);
            this.DelID.TabIndex = 9;
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
            this.panel1.Controls.Add(this.WorkerSection);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.WorkerPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.WorkerAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.WorkerPost);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.WorkerFathername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.WorkerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.HireWorker);
            this.panel1.Controls.Add(this.WorkerSurname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 311);
            this.panel1.TabIndex = 4;
            // 
            // WorkerSection
            // 
            this.WorkerSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkerSection.FormattingEnabled = true;
            this.WorkerSection.Location = new System.Drawing.Point(121, 222);
            this.WorkerSection.Name = "WorkerSection";
            this.WorkerSection.Size = new System.Drawing.Size(329, 32);
            this.WorkerSection.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Отдел: ";
            // 
            // WorkerPhone
            // 
            this.WorkerPhone.Location = new System.Drawing.Point(121, 187);
            this.WorkerPhone.MaxLength = 15;
            this.WorkerPhone.Name = "WorkerPhone";
            this.WorkerPhone.Size = new System.Drawing.Size(329, 29);
            this.WorkerPhone.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Телефон: ";
            // 
            // WorkerAddress
            // 
            this.WorkerAddress.Location = new System.Drawing.Point(121, 152);
            this.WorkerAddress.MaxLength = 100;
            this.WorkerAddress.Name = "WorkerAddress";
            this.WorkerAddress.Size = new System.Drawing.Size(329, 29);
            this.WorkerAddress.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Адрес: ";
            // 
            // WorkerPost
            // 
            this.WorkerPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkerPost.FormattingEnabled = true;
            this.WorkerPost.Location = new System.Drawing.Point(121, 114);
            this.WorkerPost.Name = "WorkerPost";
            this.WorkerPost.Size = new System.Drawing.Size(329, 32);
            this.WorkerPost.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Должность: ";
            // 
            // WorkerFathername
            // 
            this.WorkerFathername.Location = new System.Drawing.Point(121, 79);
            this.WorkerFathername.MaxLength = 20;
            this.WorkerFathername.Name = "WorkerFathername";
            this.WorkerFathername.Size = new System.Drawing.Size(329, 29);
            this.WorkerFathername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество: ";
            // 
            // WorkerName
            // 
            this.WorkerName.Location = new System.Drawing.Point(121, 44);
            this.WorkerName.MaxLength = 20;
            this.WorkerName.Name = "WorkerName";
            this.WorkerName.Size = new System.Drawing.Size(329, 29);
            this.WorkerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя: ";
            // 
            // HireWorker
            // 
            this.HireWorker.Location = new System.Drawing.Point(11, 260);
            this.HireWorker.Name = "HireWorker";
            this.HireWorker.Size = new System.Drawing.Size(438, 42);
            this.HireWorker.TabIndex = 8;
            this.HireWorker.Text = "Нанять сотрудника";
            this.HireWorker.UseVisualStyleBackColor = true;
            this.HireWorker.Click += new System.EventHandler(this.HireWorker_Click);
            // 
            // WorkerSurname
            // 
            this.WorkerSurname.Location = new System.Drawing.Point(121, 9);
            this.WorkerSurname.MaxLength = 30;
            this.WorkerSurname.Name = "WorkerSurname";
            this.WorkerSurname.Size = new System.Drawing.Size(329, 29);
            this.WorkerSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия: ";
            // 
            // WorkerList
            // 
            this.WorkerList.AllowUserToAddRows = false;
            this.WorkerList.AllowUserToDeleteRows = false;
            this.WorkerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkerList.Location = new System.Drawing.Point(0, 0);
            this.WorkerList.Margin = new System.Windows.Forms.Padding(6);
            this.WorkerList.Name = "WorkerList";
            this.WorkerList.ReadOnly = true;
            this.WorkerList.RowHeadersVisible = false;
            this.WorkerList.Size = new System.Drawing.Size(843, 305);
            this.WorkerList.TabIndex = 3;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WorkerList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FireWorker;
        private System.Windows.Forms.NumericUpDown DelID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HireWorker;
        private System.Windows.Forms.TextBox WorkerSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView WorkerList;
        private System.Windows.Forms.TextBox WorkerFathername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WorkerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WorkerSection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WorkerPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WorkerAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox WorkerPost;
        private System.Windows.Forms.Label label4;

    }
}