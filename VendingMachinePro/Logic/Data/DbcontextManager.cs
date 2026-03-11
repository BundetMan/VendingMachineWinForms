using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachinePro.Logic.Data
{
    internal sealed class DbcontextManager
    {
        private static DBContext instance;

        private DbcontextManager() { }

        public static DBContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBContext();

                return instance;
            }
        }
    }
}
