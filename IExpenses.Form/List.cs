using System;
using System.Windows.Forms;
using IExpenses;

namespace WindowsFormsApplication1
{
    public partial class List : Form
    {
        protected TrypsController Iexpenses = new TrypsController();
        public List()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {

        }
    }
}
