using CollectionViewWithActionButtons.Views;

namespace CollectionViewWithActionButtons;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        Routing.RegisterRoute("completeList", typeof(CompleteListPage));
        MainPage = new AppShell();
// #if IOS
//         ThemeLoader themeloader = new ThemeLoader();
//         themeloader.UpdateStatusBar();
// #endif
    }
}

