using UserControls.Presenter;

namespace UserControls.View
{
    public interface IMainView
    {
        MainPresenter Presenter { get; set; }
        ICompanyView DetailCompanyView { get; }
        ICompanyListView CompanyListView {get; }
        ISettingsBarView SettingBarView { get; }
    }
}