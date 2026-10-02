namespace Zadanie_6;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
		int clicks = 0;
	private void OnAddButtonClicke(object? sender, EventArgs e)
	{
		clicks++;
		ButtonLabel.Text = $"Liczba : {clicks}";
    }
    private void OnMinusButtonClicked(object? sender, EventArgs e)
    {
		if (clicks == 0)
		{
			DisplayAlert("BŁĄD!!", "Liczba nie moze byc mniejsza od 0", "OK");
		}
		else
		{
        clicks--;
        ButtonLabel.Text = $"Liczba : {clicks}";
		}

    }
    private void OnClearButtonClicked(object? sender, EventArgs e)
    {
        clicks = 0;
        ButtonLabel.Text = $"Liczba : {clicks}";
    }
}