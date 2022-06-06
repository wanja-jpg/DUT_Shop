using System;
using System.Collections.Generic;
using System.Text;

namespace DUTShopLibrary
{
    public class Enums
    {
        public enum DatabaseType : byte
        {
            Sql, // ms sql server
        }

        public enum EmployeePositions : byte
        {
            rank_1 = 1, // whatever
            rank_2 = 2,
            rank_3 = 3,
        }
    }
}
