namespace Zadanie_14;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private void SprawdzRozmiar(object sender, EventArgs e)
    {
        double szerokosc = this.Width;
        double wysokosc = this.Height;

        etykietaRozmiar.Text = $"Szerokość: {szerokosc}, Wysokość: {wysokosc}";
    }
}