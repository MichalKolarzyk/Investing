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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SqlManager.Init();
            MainForm mainForm = new MainForm();

            Application.Run(mainForm);
        }
    }
}
