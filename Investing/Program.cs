using Investing.Factories;
using Investing.Presenter;
using Investing.View;
using Repositories.SqLite;
using Repositories.Yahoo;
using Settings;
using System;
using System.Windows.Forms;
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

            IMainView mainForm = new MainForm();
            IAppSettings appSettings = SettingsAppManager.GetAppSettings();

            IPresenter<IMainView> presenter = new MainPresenter(mainForm, appSettings);

            presenter.View = mainForm;

            Application.Run(mainForm as Form);
        }
    }
}
