using MauiApp4.ViewModel;

namespace MauiApp4;

public partial class FirstPage : ContentPage
{
	public FirstPage()
	{
		InitializeComponent();
	}

    public FirstPage(int count = 0)
    {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new FirstViewModel();
            _vm.Count = count;
            _vm.Message = "ここは新しいページです";
            this.BindingContext = _vm;
        };
    }
    FirstViewModel _vm;

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void OnCountClicked(object sender, EventArgs e)
    {
        _vm.Count++;
    }
}
