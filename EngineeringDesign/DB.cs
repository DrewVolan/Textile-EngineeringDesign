using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringDesign
{
    class DB
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "std-mysql";
            int port = 3306;
            string database = "std_1313";
            string username = "std_1313";
            string password = "drewIvlev";

            return DBMySQLUnits.GetDBConnection(host, port, database, username, password);
        }
    }
}