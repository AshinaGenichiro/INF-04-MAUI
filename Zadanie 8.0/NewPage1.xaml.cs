

namespace Zadanie_8._0;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	public async void ClearButtonClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert(
            "Potwierdzenie",
            "Czy na pewno chesz wyczyscic formularz",
            "Tak",
            "Nie"
         );
        if (confirm)
        {

            WidthEntry.Text = string.Empty;
            HeightEntry.Text = string.Empty;
        }
    }
    public void CalculateButtonClicked(object sender, EventArgs e)
    {
        if (double.TryParse(WidthEntry.Text, out double width) && double.TryParse(HeightEntry.Text, out double height))
        {
            if(width > 0 && height > 0)
            {
                double area = width * height;
                double perimeter = 2 * (width + height);
               DisplayAlert("Wyniki", $"Pole: {area}\nObwód: {perimeter}", "OK");
            }
            else
            {
                DisplayAlert("Błąd", "Szerokość i wysokość muszą być większe od zera.", "OK");
            }
        }
        else
        {
            DisplayAlert("Błąd", "Podaj poprawne liczby dla szerokości i wysokości.", "OK");
        }
    }
}