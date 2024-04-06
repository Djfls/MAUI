using MauiApp8.ViewModel;

namespace MauiApp8
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
        public NaviShellPageViewModel NaviShellPageViewModel { get; set; }
    }
}
