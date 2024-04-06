using MauiApp8.ViewModel;

namespace MauiApp8;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            // ƒoƒCƒ“ƒh‚·‚é
            this.BindingContext = (App.Current as App).NaviShellPageViewModel;
        };
    }
    private void OnCountClicked(object sender, EventArgs e)
    {
        var vm = this.BindingContext as NaviShellPageViewModel;
        vm.Count++;
    }

}