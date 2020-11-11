using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using UserControls;

namespace Investing
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();

            Application.Run(mainForm);
        }

        private static void Test()
        {
            SqlAccess sqlAccess = new SqlAccess(@"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;");
            Prices prices = YahooAccess.GetPrices(sqlAccess.Get<Company>());
            sqlAccess.Insert(prices);
        }
    }
}
