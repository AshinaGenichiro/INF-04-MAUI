namespace Inf04_maui;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
    private void OrderButton(object? sender, EventArgs e)
    {
        if(!string.IsNullOrWhiteSpace(ProductEntry.Text) && !string.IsNullOrWhiteSpace(AmountEntry.Text) && !string.IsNullOrWhiteSpace(AddresEntry.Text))
        {
            DisplayAlertAsync("Złożyłeś zamówienie",$"Produkt:{ProductEntry.Text},ilość: {AmountEntry.Text}, adres: {AddresEntry.Text}", "OK");
        }
        else
        {
            DisplayAlertAsync("Nie złożyleś zamowienia", "Prosze o wypełnienie wszystkich pół", "OK");
        }

    }
}