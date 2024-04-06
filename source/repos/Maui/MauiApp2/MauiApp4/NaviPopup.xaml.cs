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
            _vm.Message = "�悤���� .NET MAUI �̐��E��";
            this.BindingContext = _vm;
        };
    }
    NaviPopupViewModel _vm;

    private async void OnFirstClicked(object sender, EventArgs e)
    {
        // �ꕔ�̃f�[�^�̂ݓn��
        await this.Navigation.PushAsync(new FirstPage(_vm.Count));
    }
    private async void OnSecondClicked(object sender, EventArgs e)
    {
        // �e�� ViewModel �������p��
        await this.Navigation.PushAsync(new SecondPage() { BindingContext = _vm });
    }

    private void OnCountClicked(object sender, EventArgs e)
    {
        _vm.Count++;
    }

}