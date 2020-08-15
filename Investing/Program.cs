using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooFinanceApi;

namespace Investing
{
    static class Program
    {
        

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var kosSymbol = "KOS";
            //var securities = await Yahoo.Symbols(kosSymbol).Fields(Field.Symbol).QueryAsync();

            //var security = securities[kosSymbol];
            //var securitySymbol = security[Field.Symbol];

            //Sync test
            //Changes from GitHub

            Application.Run(new Form1());

        }
    }
}
