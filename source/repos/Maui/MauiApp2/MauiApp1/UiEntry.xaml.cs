namespace MauiApp1;

public partial class UiEntry : ContentPage
{
	public UiEntry()
	{
		InitializeComponent();
	}
    /// <summary>
    /// ���M�{�^�����N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnClickCommit(object sender, EventArgs e)
    {
        string name = textName.Text;
        string addr = textAddress.Text;
        labelMessage.Text = $"{name} in {addr}";
    }
}