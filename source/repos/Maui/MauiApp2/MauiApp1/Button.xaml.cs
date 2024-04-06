namespace MauiApp1;

public partial class Button : ContentPage
{
	public Button()
	{
		InitializeComponent();
	}
    private int _count = 0;

    /// <summary>
    /// �J�E���^�[�{�^�����N���b�N
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;
        btnCounter.Text = $"Count: {_count}";
    }

    /// <summary>
    /// ���ݎ�����\��
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDateTimeClicked(object sender, EventArgs e)
    {
        textNow.Text = DateTime.Now.ToString();
    }
}