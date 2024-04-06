using MauiApp4.ViewModel;

namespace MauiApp4;

public partial class NaviPopup : ContentPage
{
	public NaviPopup()
    {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new NaviPopupViewModel();
            _vm.Message = "ようこそ .NET MAUI の世界へ";
            this.BindingContext = _vm;
        };
    }
    NaviPopupViewModel _vm;

    private async void OnFirstClicked(object sender, EventArgs e)
    {
        // 一部のデータのみ渡す
        await this.Navigation.PushAsync(new FirstPage(_vm.Count));
    }
    private async void OnSecondClicked(object sender, EventArgs e)
    {
        // 親の ViewModel を引き継ぐ
        await this.Navigation.PushAsync(new SecondPage() { BindingContext = _vm });
    }

    private void OnCountClicked(object sender, EventArgs e)
    {
        _vm.Count++;
    }

}