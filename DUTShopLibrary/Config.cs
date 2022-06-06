using DUTShopLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using static DUTShopLibrary.Enums;

namespace DUTShopLibrary
{
    public class Config
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType connectionType)
        {
            if (connectionType == DatabaseType.Sql)
            {
                Connection = new SqlConnector();

            }
        }

        public static string CnnString(string name)
        {

            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
