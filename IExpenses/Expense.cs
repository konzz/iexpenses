using System;

namespace IExpenses
{
    public class Expense
    {
        public double Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Expense(double amount, string description, DateTime date)
        {
            Amount = amount;
            Description = description;
            Date = date;
        }
    }
}