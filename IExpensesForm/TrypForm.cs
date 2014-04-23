using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IExpenses;

namespace IExpensesForm
{
    public partial class TrypForm : Form
    {
        protected Tryp Tryp;
        public TrypForm(Tryp tryp)
        {
            InitializeComponent();
            Tryp = tryp;
            UpdateNumbers();
            UpdateExpensesList();
        }

        protected void UpdateNumbers()
        {
            UpdateBudget();
            UpdateExpenses();
            UpdateBalance();
        }

        protected void UpdateBudget()
        {
            budget.IntValue = Tryp.GetBudget().Total;
        }

        protected void UpdateExpenses()
        {
            expenses.DecimalValue = Tryp.GetTotalExpenses();
        }

        protected void UpdateBalance()
        {
            var balanceAmount = Tryp.GetBudget().Total - Tryp.GetTotalExpenses();
            balance.Text = balanceAmount.ToString();
        }

        protected void UpdateExpensesList()
        {
            var expenses = Tryp.GetExpenses();
            expensesList.Items.Clear();
            expenses.ForEach(expense =>
            {
                var listItem =
                    new ListViewItem(new[]
                    {expense.Description, expense.Amount.ToString(), expense.Date.ToShortDateString()});
                expensesList.Items.Add(listItem);
            });
        }

        private void addExpense_Click(object sender, EventArgs e)
        {
            var expense = new Expense(expenseAmount.DecimalValue, expenseDescription.Text, expenseDate.Value);
            Tryp.AddExpense(expense);
            
            expenseAmount.Clear();
            expenseDescription.Clear();
            expenseDate.Value = DateTime.Today;

            UpdateExpensesList();
            UpdateNumbers();
        }

        private void TrypForm_Load(object sender, EventArgs e)
        {

        }
    }
}
