namespace Zadanie_7;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    double R=0, G=0, B=0;
    
    private void SliderChanged(object? sender, EventArgs e)
    {
        string hexColor = $"#{(int)Math.Round(RedSlider.Value):X2}{(int)Math.Round(GreenSlider.Value):X2}{(int)Math.Round(BlueSlider.Value):X2}";
        R = Math.Round(RedSlider.Value);
        G = Math.Round(GreenSlider.Value);
        B = Math.Round(BlueSlider.Value);

        this.BackgroundColor = Color.Parse(hexColor);

        HexColorLabel.Text = hexColor;
    }
}