using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQLApp
{
    class DBHandler
    {
        private MySqlConnection connection;
        PropertiesHandler propertiesHandler = new PropertiesHandler();
        
        public void openConnection()
        {
            propertiesHandler.readSettings();
            connection = new MySqlConnection("server=" + propertiesHandler.Host 
                                            + "port=" + propertiesHandler.Port 
                                            + "username=" + propertiesHandler.User 
                                            + "password=" + propertiesHandler.Password 
                                            + "database=" + propertiesHandler.Database);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
