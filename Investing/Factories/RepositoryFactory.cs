using Repositories.Interfaces;
using Repositories.SqLite;
using Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investing.Factories
{
    public static class RepositoryFactory
    {
        static IAppSettings _appSettings;
        static RepositoryFactory()
        {
            _appSettings = SettingsAppManager.GetAppSettings();
        }

        public static ICompanyRepository CreateCompanyRepository()
        {
            return new CompanySqlightRepository(_appSettings.DataBasePath);
        }

    }
}
