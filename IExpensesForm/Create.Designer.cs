namespace IExpensesForm
{
    partial class Create
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
            this.trypName = new System.Windows.Forms.TextBox();
            this.createTryp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trypStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weekendExtra = new IExpensesForm.NumericTextBox();
            this.trypBudget = new IExpensesForm.NumericTextBox();
            this.SuspendLayout();
            // 
            // trypName
            // 
            this.trypName.Location = new System.Drawing.Point(12, 46);
            this.trypName.Name = "trypName";
            this.trypName.Size = new System.Drawing.Size(148, 22);
            this.trypName.TabIndex = 0;
            // 
            // createTryp
            // 
            this.createTryp.Location = new System.Drawing.Point(326, 106);
            this.createTryp.Name = "createTryp";
            this.createTryp.Size = new System.Drawing.Size(75, 23);
            this.createTryp.TabIndex = 4;
            this.createTryp.Text = "Create";
            this.createTryp.UseVisualStyleBackColor = true;
            this.createTryp.Click += new System.EventHandler(this.createTryp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Budget per day";
            // 
            // trypStartDate
            // 
            this.trypStartDate.Location = new System.Drawing.Point(15, 107);
            this.trypStartDate.Name = "trypStartDate";
            this.trypStartDate.Size = new System.Drawing.Size(288, 22);
            this.trypStartDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weekend extra";
            // 
            // weekendExtra
            // 
            this.weekendExtra.AllowSpace = false;
            this.weekendExtra.Location = new System.Drawing.Point(292, 46);
            this.weekendExtra.Name = "weekendExtra";
            this.weekendExtra.Size = new System.Drawing.Size(109, 22);
            this.weekendExtra.TabIndex = 2;
            this.weekendExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // trypBudget
            // 
            this.trypBudget.AllowSpace = false;
            this.trypBudget.Location = new System.Drawing.Point(167, 46);
            this.trypBudget.Name = "trypBudget";
            this.trypBudget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trypBudget.Size = new System.Drawing.Size(119, 22);
            this.trypBudget.TabIndex = 1;
            this.trypBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 164);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weekendExtra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trypStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createTryp);
            this.Controls.Add(this.trypBudget);
            this.Controls.Add(this.trypName);
            this.Name = "Create";
            this.Text = "IExpenses Create";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox trypName;
        private NumericTextBox trypBudget;
        private System.Windows.Forms.Button createTryp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker trypStartDate;
        private System.Windows.Forms.Label label3;
        private NumericTextBox weekendExtra;
        private System.Windows.Forms.Label label4;
    }
}