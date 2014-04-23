namespace IExpensesForm
{
    partial class TrypForm
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
            this.actualBudgetLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expensesList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.expenseDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addExpense = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.expenseDate = new System.Windows.Forms.DateTimePicker();
            this.expenseAmount = new IExpensesForm.NumericTextBox();
            this.balance = new IExpensesForm.NumericTextBox();
            this.expenses = new IExpensesForm.NumericTextBox();
            this.budget = new IExpensesForm.NumericTextBox();
            this.SuspendLayout();
            // 
            // actualBudgetLabel
            // 
            this.actualBudgetLabel.AutoSize = true;
            this.actualBudgetLabel.Location = new System.Drawing.Point(13, 15);
            this.actualBudgetLabel.Name = "actualBudgetLabel";
            this.actualBudgetLabel.Size = new System.Drawing.Size(96, 17);
            this.actualBudgetLabel.TabIndex = 0;
            this.actualBudgetLabel.Text = "Actual Budget";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Expenses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Balance";
            // 
            // expensesList
            // 
            this.expensesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.amount,
            this.date});
            this.expensesList.Location = new System.Drawing.Point(323, 40);
            this.expensesList.Name = "expensesList";
            this.expensesList.Size = new System.Drawing.Size(405, 407);
            this.expensesList.TabIndex = 6;
            this.expensesList.UseCompatibleStateImageBehavior = false;
            this.expensesList.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 225;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 68;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 107;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Expenses list";
            // 
            // expenseDescription
            // 
            this.expenseDescription.Location = new System.Drawing.Point(125, 194);
            this.expenseDescription.Name = "expenseDescription";
            this.expenseDescription.Size = new System.Drawing.Size(189, 22);
            this.expenseDescription.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Add expense";
            // 
            // addExpense
            // 
            this.addExpense.Location = new System.Drawing.Point(242, 325);
            this.addExpense.Name = "addExpense";
            this.addExpense.Size = new System.Drawing.Size(75, 23);
            this.addExpense.TabIndex = 2;
            this.addExpense.Text = "Add";
            this.addExpense.UseVisualStyleBackColor = true;
            this.addExpense.Click += new System.EventHandler(this.addExpense_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // expenseDate
            // 
            this.expenseDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseDate.Location = new System.Drawing.Point(125, 276);
            this.expenseDate.Name = "expenseDate";
            this.expenseDate.Size = new System.Drawing.Size(189, 18);
            this.expenseDate.TabIndex = 14;
            // 
            // expenseAmount
            // 
            this.expenseAmount.AllowSpace = false;
            this.expenseAmount.Location = new System.Drawing.Point(125, 232);
            this.expenseAmount.Name = "expenseAmount";
            this.expenseAmount.Size = new System.Drawing.Size(100, 22);
            this.expenseAmount.TabIndex = 1;
            this.expenseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // balance
            // 
            this.balance.AllowSpace = false;
            this.balance.Location = new System.Drawing.Point(125, 71);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(100, 22);
            this.balance.TabIndex = 5;
            this.balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expenses
            // 
            this.expenses.AllowSpace = false;
            this.expenses.Location = new System.Drawing.Point(125, 40);
            this.expenses.Name = "expenses";
            this.expenses.ReadOnly = true;
            this.expenses.Size = new System.Drawing.Size(100, 22);
            this.expenses.TabIndex = 3;
            this.expenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // budget
            // 
            this.budget.AllowSpace = false;
            this.budget.Location = new System.Drawing.Point(125, 12);
            this.budget.Name = "budget";
            this.budget.ReadOnly = true;
            this.budget.Size = new System.Drawing.Size(100, 22);
            this.budget.TabIndex = 1;
            this.budget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TrypForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 465);
            this.Controls.Add(this.expenseDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addExpense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expenseDescription);
            this.Controls.Add(this.expenseAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expensesList);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.actualBudgetLabel);
            this.Name = "TrypForm";
            this.Text = "TrypForm";
            this.Load += new System.EventHandler(this.TrypForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label actualBudgetLabel;
        private NumericTextBox budget;
        private NumericTextBox expenses;
        private System.Windows.Forms.Label label1;
        private NumericTextBox balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView expensesList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.Label label3;
        private NumericTextBox expenseAmount;
        private System.Windows.Forms.TextBox expenseDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addExpense;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expenseDate;
    }
}