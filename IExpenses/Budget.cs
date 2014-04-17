using System.Runtime.InteropServices;

namespace IExpenses
{
    public class Budget
    {
        public int Id { get; set; }
        public int Daily { get; set; }
        public int Total { get; set; }
        public int WeekEnd { get; set; }
    }
}