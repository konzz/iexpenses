using System;
using System.Windows.Forms;
using IExpenses;

namespace IExpensesForm
{
    public partial class TrypsList : Form
    {
        protected TrypsController TrypsController = new TrypsController();

        public TrypsList()
        {
            InitializeComponent();
            RefreshList();
        }

        private void create_Click(object sender, EventArgs e)
        {
            var createForm = new Create();
            createForm.FormClosed += OnCreation;
            createForm.ShowDialog();
        }

        private void OnCreation(object sender, FormClosedEventArgs e)
        {
            RefreshList();
        }

        protected void RefreshList()
        {
            list.Items.Clear();
            var trypsNames = TrypsController.GetTrypNames();
            trypsNames.ForEach(name => list.Items.Add(name));
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (list.SelectedItem == null) return;

            var message = "Are you sure to delete this tryp ??";
            var confirmResult = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                TrypsController.DeleteTryp(list.GetItemText(list.SelectedItem));
                RefreshList();
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (list.SelectedItem == null) return;
            var trypName = list.GetItemText(list.SelectedItem);
            var tryp = TrypsController.GetTrypByName(trypName);
            ShowTryp(tryp);
        }

        protected void ShowTryp(Tryp tryp)
        {
            var trypFrom = new TrypForm(tryp);
            trypFrom.ShowDialog();
        }

    }
}
