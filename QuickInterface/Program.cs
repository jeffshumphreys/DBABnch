using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace QuickInterface
{
    static class Program
    {
        public const string CONN_STR = "Data Source=JRS01LT994\\Junk;Database=DBABnch_LOCAL;Connect Timeout=2;MultipleActiveResultSets=True;Integrated Security=SSPI;Connect Timeout=2;";

        // The main entry point for the application.
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new UI_Views.MainView());
        }
    }
}
