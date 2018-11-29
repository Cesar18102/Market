namespace Market
{
    partial class Summary
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
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Profit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Start.Location = new System.Drawing.Point(263, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 29);
            this.Start.TabIndex = 0;
            // 
            // End
            // 
            this.End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.End.Location = new System.Drawing.Point(263, 47);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(200, 29);
            this.End.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начало периода: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Окончание периода: ";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(16, 82);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(447, 43);
            this.Calc.TabIndex = 2;
            this.Calc.Text = "Расчитать прибыль";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Прибыль:  ";
            // 
            // Profit
            // 
            this.Profit.AutoSize = true;
            this.Profit.Location = new System.Drawing.Point(123, 155);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(0, 24);
            this.Profit.TabIndex = 6;
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 199);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Summary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.DateTimePicker End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Profit;
    }
}