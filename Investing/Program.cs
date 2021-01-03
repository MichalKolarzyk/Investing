using Investing.Factories;
using Repositories.SqLite;
using Repositories.Yahoo;
using Settings;
using System;
using System.Windows.Forms;
using UserControls;
using UserControls.Presenter;
using UserControls.View;

namespace Investing
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainView mainForm = ViewsFactory.CreateMainForm();

            var presenter = PresentersFactory.CreateMainPresenter();
            presenter.View = mainForm;

            Application.Run(mainForm as Form);
        }
    }
}
