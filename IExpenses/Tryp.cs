using System;
using System.Collections.Generic;
using System.Linq;
using Littledb;

namespace IExpenses
{
    public class Tryp
    {
        private readonly LittleDB _db;

        public Tryp(LittleDB db)
        {
            _db = db;
            Update();
        }

        public void Initialize(DateTime startDate, int perDayBudget, int weekendExtraBudget)
        {
            SetStartDate(startDate);
            SetBudgetPerDay(perDayBudget);
            SetWeekendExtra(weekendExtraBudget);
            IncreaseBudget(perDayBudget);
            Update();
        }

        protected void Update()
        {
            if (_db.GetAll<DateTime>().Count == 0) return;
            
            var daysSinceLastUpdate = GetDaysSinceLastUpdate();
            IncreaseBudget(CalculateBudgetForDays(daysSinceLastUpdate));
            var daysAlreadyCounted = _db.GetAll<DateTime>();
            var newDays = daysAlreadyCounted.Union(daysSinceLastUpdate).ToList();
            _db.SaveList(newDays);
        }

        public void IncreaseBudget(int amount)
        {
            var budget = GetBudget();
            budget.Total = budget.Total + amount;
            SaveBudget(budget);
        }

        public int CalculateBudgetForDays(List<DateTime> days)
        {   var budgetPerDay = GetBudget().Daily;
            var weekEndExtra = GetBudget().WeekEnd;
            var budget = budgetPerDay*days.Count;

            days.ForEach(day =>
            {
                if (day.DayOfWeek == DayOfWeek.Saturday)
                {
                    budget = budget + weekEndExtra;
                }
            });

            return budget;
        }

        protected List<DateTime> GetDaysSinceLastUpdate()
        {
            var today = DateTime.Today;
            var lastDayCounted = _db.GetAll<DateTime>().Last();
            var days = new List<DateTime>();
            for (var date = lastDayCounted; date < today; date = date.AddDays(1))
            {
                days.Add(date.AddDays(1));
            }

            return days;
        }

        protected void SetStartDate(DateTime startDate)
        {
            if (_db.GetAll<DateTime>().Any())
            {
                throw new InvalidOperationException();
            }
            _db.Save(startDate);
        }

        public void SetBudgetPerDay(int amount)
        {
            var budget = GetBudget();
            budget.Daily = amount;
            SaveBudget(budget);
        }

        protected void SetWeekendExtra(int amount)
        {
            var budget = GetBudget();
            budget.WeekEnd = amount;
            SaveBudget(budget);
        }

        public Budget GetBudget()
        {
            return _db.GetAll<Budget>().FirstOrDefault() ?? new Budget();
        }

        private void SaveBudget(Budget budget)
        {
            _db.Save(budget);
        }

        public void AddExpense(Expense expense)
        {
            _db.Save(expense);
        }

        public List<Expense> GetExpenses()
        {
            return _db.GetAll<Expense>();
        }

        public decimal GetTotalExpenses()
        {
            var expenses = GetExpenses();
            return expenses.Sum(expense => expense.Amount);
        }
    }
}
