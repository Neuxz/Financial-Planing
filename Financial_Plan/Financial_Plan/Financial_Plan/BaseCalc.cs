using System;

namespace Financial_Plan
{
    public class BaseCalc
    {
        private static ADatabase database;
        public void setDatabase(ADatabase db)
        {
            database = db;
        }
        public BaseCalc()
        {

        }
    }
}

