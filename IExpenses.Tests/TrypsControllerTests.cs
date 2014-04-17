using System;
using System.IO;
using FluentAssertions;
using NUnit.Framework;
using Littledb;

namespace IExpenses.Tests
{
    [TestFixture]
    class TrypsControllerTests
    {
        [Test]
        public void CanCreateNewExpensesTryp()
        {
            var trypsDb = new LittleDB("tryps");

            var iexpenses = new TrypsController();
            Tryp newYorkTryp = iexpenses.CreateNewTryp(DateTime.Now, 50, 0, "New York");

            trypsDb.GetAll<TrypRecord>().Count.ShouldBeEquivalentTo(1);
        }

        [Test]
        public void CanGetAlIstOfTrypNames()
        {
            var iexpenses = new TrypsController();
            iexpenses.CreateNewTryp(DateTime.Now, 50, 10, "New York");
            iexpenses.CreateNewTryp(DateTime.Now, 50, 30, "Brazil");
            iexpenses.CreateNewTryp(DateTime.Now, 70, 20, "India");

            var trypNames = iexpenses.GetTrypNames();
            trypNames.ShouldBeEquivalentTo(new []{"New York", "Brazil", "India"});
        }

        [Test]
        public void CanRecoverATrypByName()
        {
            var iexpenses = new TrypsController();
            iexpenses.CreateNewTryp(DateTime.Now, 41, 28, "New York");
            var tryp = iexpenses.GetTrypByName("New York");
            tryp.GetBudget().Daily.ShouldBeEquivalentTo(41);
            tryp.GetBudget().WeekEnd.ShouldBeEquivalentTo(28);
        }

        [Test]
        public void CanDeleteTryps()
        {
            var iexpenses = new TrypsController();
            iexpenses.CreateNewTryp(DateTime.Now, 41, 28, "Ecuador");
            iexpenses.DeleteTryp("Ecuador");
            iexpenses.GetTrypNames().Contains("Ecuador").Should().Be(false);
            Directory.Exists("Ecuador").ShouldBeEquivalentTo(false);
        }

        [TearDown]
        public void RemoveDb()
        {
            try
            {
                Directory.Delete("tryps", true);
                Directory.Delete("New York", true);
                Directory.Delete("Brazil", true);
                Directory.Delete("India", true);
            }
            catch
            {
                
            }
            
        }
    }
}
