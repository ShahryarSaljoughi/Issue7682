[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Issue7682.Client.Maui;

public partial class App
{
    public App(MainPage mainPage)
    {
        InitializeComponent();

        MainPage = new NavigationPage(mainPage);
    }
}
