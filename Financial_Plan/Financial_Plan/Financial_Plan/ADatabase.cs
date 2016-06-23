using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Plan
{
    public abstract class ADatabase
    {
        protected const string SELECT_FINANCIES = "";
        protected const string INSERT_FINANCIES = "";
        private string DATABASE_PW;
        public abstract bool DATABASE_EXISTS{ get; }
        public abstract bool DATABASE_HAS_VALUE { get; }
        public abstract bool moneyEntryToDB(MoneyEntry mo);
        public abstract List<MoneyEntry> getEntryFromDB();
        public abstract List<MoneyEntry> getEntryInMonthFromDB();
        public abstract List<MoneyEntry> getEntryFromDBFromMonth(DateTime month);
    }
}
