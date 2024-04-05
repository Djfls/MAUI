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
            _vm.Message = "‚æ‚¤‚±‚» .NET MAUI ‚Ì¢ŠE‚Ö";
            this.BindingContext = _vm;
        };
    }
    NaviPopupViewModel _vm;

    private async void OnFirstClicked(object sender, EventArgs e)
    {
        // ˆê•”‚Ìƒf[ƒ^‚Ì‚İ“n‚·
        await this.Navigation.PushAsync(new FirstPage(_vm.Count));
    }
    private async void OnSecondClicked(object sender, EventArgs e)
    {
        // e‚Ì ViewModel ‚ğˆø‚«Œp‚®
        await this.Navigation.PushAsync(new SecondPage() { BindingContext = _vm });
    }

    private void OnCountClicked(object sender, EventArgs e)
    {
        _vm.Count++;
    }

}