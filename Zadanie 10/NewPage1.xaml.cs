namespace Zadanie_10;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	public void onButtonClicked(object sender, EventArgs e)
    {
		int value = (int)SliderValue.Value;
        this.BackgroundColor = Color.FromRgb(value, value, value);
    }
}