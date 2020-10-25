using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Investing
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //SqlAccess sqlAccess = new SqlAccess(@"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;");
            //Prices prices = YahooAccess.GetPrices(sqlAccess.Get<Company>());
            //sqlAccess.Insert(prices);

            MainForm mainForm = new MainForm();

            Application.Run(mainForm);
        }
    }
}
