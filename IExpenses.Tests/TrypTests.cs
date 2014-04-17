using System;
using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using Littledb;
using NUnit.Framework;

namespace IExpenses.Tests
{
    [TestFixture]
    public class TrypTests
    {
        [Test]
        public void ItRequiresDBConnexion()
        {
            var db = new LittleDB("newYorkTryp");
            var newyorkExpenses = new Tryp(db);
        }

        [Test]
        public void CanBeInitialized()
        {
            var db = new LittleDB("newYorkTryp");
            var newYorkExpenses = new Tryp(db);
            var today = DateTime.Now;
            newYorkExpenses.Initialize(today, 50, 0);

            newYorkExpenses.GetBudget().Total.Should().Be(50);
            newYorkExpenses.GetBudget().Daily.Should().Be(50);
        }

        [Test]
        public void ItShouldThrowAnExceptionIfAlreadyInitialized()
        {
            var today = DateTime.Today;
            var db = new LittleDB("newYorkTryp");
            var newyorkExpenses = new Tryp(db);

            newyorkExpenses.Initialize(today, 20, 10);
            Assert.Throws<InvalidOperationException>(() => newyorkExpenses.Initialize(today, 20, 10));
        }

        [Test]
        public void EachTimeIInstantiateItShouldUpdateTheTotalBudgetBasedOnDays()
        {
            var twoDaysAgo = DateTime.Today.AddDays(-2);
            var db = new LittleDB("newYorkTryp");
            var newyorkExpenses = new Tryp(db);
            newyorkExpenses.Initialize(twoDaysAgo, 20, 0);

            newyorkExpenses.GetBudget().Total.ShouldBeEquivalentTo(60);
        }

        [Test]
        public void CalculateBudgetShouldAddTheWeekendExtraForEachSaturday()
        {
            var friday = new DateTime(2014, 4, 11);
            var saturday = new DateTime(2014, 4, 12);
            var sunday = new DateTime(2014, 4, 13);
            var db = new LittleDB("newYorkTryp");
            var newyorkExpenses = new Tryp(db);
            newyorkExpenses.Initialize(friday, 10, 3);
            var daysToUpdate = new List<DateTime>(){friday, saturday, sunday};
            newyorkExpenses.CalculateBudgetForDays(daysToUpdate).ShouldBeEquivalentTo(33);
        }

        [Test]
        public void ItShouldUpdateTheBudgetonInstance()
        {
            var db = new LittleDB("newYorkTryp");

            var threeDaysAgo = DateTime.Today.AddDays(-3);
            var twoDaysAgo = DateTime.Today.AddDays(-2);
            db.SaveList(new List<DateTime>(){threeDaysAgo, twoDaysAgo});
            
            var budget = new Budget {Daily = 20, Id = 1, Total = 40};
            db.Save(budget);

            var newyorkExpenses = new Tryp(db);
            newyorkExpenses.GetBudget().Total.ShouldBeEquivalentTo(80);
        }

        [Test]
        public void CanAddExpensesAndRecoverThem()
        {
            var db = new LittleDB("newYorkTryp");
            var newyorkExpenses = new Tryp(db);

            var food = new Expense(20.3, "Food", DateTime.Today);
            newyorkExpenses.AddExpense(food);

            var expenses = newyorkExpenses.GetExpenses();
            expenses.Count.Should().Be(1);
            expenses[0].Amount.Should().Be(20.3);

            var taxiExpense = new Expense(5, "Taxi", DateTime.Today);
            newyorkExpenses.AddExpense(taxiExpense);

            var actualizedExpenses = newyorkExpenses.GetExpenses();
            actualizedExpenses.Count.Should().Be(2);
            actualizedExpenses[1].Description.Should().Be("Taxi");
        }

        [Test]
        public void CanCountExpenses()
        {
            var db = new LittleDB("newYorkTryp");
            var newyorkExpenses = new Tryp(db);

            var food = new Expense(20.3, "Food", DateTime.Today);
            var taxi = new Expense(3.2, "Taxi", DateTime.Today);
            newyorkExpenses.AddExpense(food);
            newyorkExpenses.AddExpense(taxi);

            newyorkExpenses.GetTotalExpenses().Should().Be(23.5);
        }

        [Test]
        public void OnInstanceItShouldUpdateTheBudgetBasedOnDays()
        {
            var db = new LittleDB("newYorkTryp");
            var newyorkExpenses = new Tryp(db); 
        }

        [TearDown]
        public void RemoveDb()
        {
            Directory.Delete("newYorkTryp", true);
        }
    }


}
