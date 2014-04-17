using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Littledb;

namespace IExpenses
{
    public class TrypsController
    {
        protected LittleDB Db = new LittleDB("tryps");

        /// <summary>
        /// Creates and initializes a new tryp
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="dailyBudget"></param>
        /// <param name="weekEndExtra"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public Tryp CreateNewTryp(DateTime startDate, int dailyBudget, int weekEndExtra, string name)
        {
            var tryp = CreateTryp(startDate, dailyBudget, weekEndExtra, name);
            CreateTrypRecord(name);
            return tryp;
        }

        /// <summary>
        /// Returns a list of tryp names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetTrypNames()
        {
            var names = new List<String>();
            Db.GetAll<TrypRecord>().ForEach(tryp => names.Add(tryp.Name));
            return names;
        }

        /// <summary>
        /// Recovers a tryp by the name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Tryp GetTrypByName(string name)
        {
            var db = new LittleDB(name);
            return new Tryp(db);
        }

        protected void CreateTrypRecord(string name)
        {
            var trypRecord = new TrypRecord(name);
            Db.Save(trypRecord);
        }

        protected Tryp CreateTryp(DateTime startDate, int dailyBudget, int weekEndExtra, string name)
        {
            var trypDb = new LittleDB(name);
            var tryp = new Tryp(trypDb);
            tryp.Initialize(startDate, dailyBudget, weekEndExtra);

            return tryp;
        }
    }
}
