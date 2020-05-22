using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQLApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {

            //var script = File.ReadAllText("..\\..\\Backup.sql");
            //MySqlConnection conn = new MySqlConnection();
            //MySqlCommand cmd = new MySqlCommand(script, conn);
            //{
            //    conn.Open();
            //    cmd.ExecuteNonQuery();
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Shop());
        }
    }
}
