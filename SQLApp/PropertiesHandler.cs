using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace SQLApp
{
    class PropertiesHandler
    {
        private static string PATH_TO_SETTINGS = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"dbconnection.properties");

        private string _host;
        private string _port;
        private string _user;
        private string _password;
        private string _database;
        public PropertiesHandler()
        {
            //var data = new Dictionary<string, string>();
            //foreach (var row in File.ReadAllLines(PATH_TO_SETTINGS))
            //{
            //    data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));
            //}
        }       
        public void readSettings()
        {
            var data = new Dictionary<string, string>();
            foreach (var row in File.ReadAllLines(PATH_TO_SETTINGS))
            {
                data.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));
                //data.Add(row.Split('=')[0], row.Split('=')[1] + ";");
            }
            _host = data["host"];
            _port = data["port"];
            _user = data["user"];
            _password = data["password"];
            _database = data["database"];
        }

        public  string Host { get => _host; set => _host = value; }
        public  string Port { get => _port; set => _port = value; }
        public  string User { get => _user; set => _user = value; }
        public  string Password { get => _password; set => _password = value; }
        public  string Database { get => _database; set => _database = value; }

    }
}
