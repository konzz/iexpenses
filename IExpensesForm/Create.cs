using System;
using System.Windows.Forms;
using IExpenses;

namespace IExpensesForm
{
    public partial class Create : Form
    {
        protected TrypsController TrypsController = new TrypsController();
        public Create()
        {
            InitializeComponent();
        }

        private void createTryp_Click(object sender, EventArgs e)
        {
            TrypsController.CreateNewTryp(trypStartDate.Value, trypBudget.IntValue, weekendExtra.IntValue, trypName.Text);
            Close();
        }
    }
}
