using System;

namespace IExpenses
{
    public class Expense
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Expense(decimal amount, string description, DateTime date)
        {
            Amount = amount;
            Description = description;
            Date = date;
        }
    }
}