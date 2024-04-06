using MauiApp8.ViewModel;
namespace MauiApp8;

public partial class FirstPage : ContentPage
{
    public FirstPage()
    {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            _vm = new FirstViewModel();
            _vm.Message = "�����͐V�����y�[�W�ł�";
            this.BindingContext = _vm;
        };
    }
    FirstViewModel _vm;

    private void OnCountClicked(object sender, EventArgs e)
    {
        _vm.Count++;
    }
}