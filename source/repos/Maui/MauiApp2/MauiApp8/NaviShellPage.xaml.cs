using MauiApp8.ViewModel;

namespace MauiApp8;

public partial class NaviShellPage : ContentPage
{
	public NaviShellPage()
	{
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new NaviShellPageViewModel();
            _vm.Message = "�悤���� .NET MAUI �̐��E��";
            this.BindingContext = _vm;
            // App�N���X�ɕۑ����Ă���
            (App.Current as App).NaviShellPageViewModel = _vm;
        };
    }
    NaviShellPageViewModel _vm;

    private async void OnFirstClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//first");
    }
    private async void OnSecondClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//second");
    }
    private void OnCountClicked(object sender, EventArgs e)
    {
        _vm.Count++;
    }
}