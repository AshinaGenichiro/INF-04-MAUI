namespace Zadanie_5;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{

		InitializeComponent();
        wyborDaty.MinimumDate = DateTime.Today;
    }
    string sala;
    int iloscOsob;
    private void onSaleChanged(object? sender, EventArgs e)
    {
       if(sale.SelectedItem?.ToString() != null)
        {
            sala = sale.SelectedItem.ToString();
        }
    }
    private void OnIloscOsobChanged(object? sender, EventArgs e)
    {
        iloscOsob = (int)LiczbaOsob.Value;
        if(LiczbaOsob.Value >0)
        {
            LabelLiczbaOs.Text = $"Ilosc osob: {LiczbaOsob.Value}";
        }
    }
   
    private void OnBookButtonClicked(object? sender, EventArgs e)
    {
        if (sale.SelectedItem?.ToString() != null && iloscOsob >0)
        {
            if (wyborDaty.Date.HasValue)
            {
                DateTime wybranaData = wyborDaty.Date.Value;

                Podsumowanie.Text = $"{sala}, {iloscOsob} os., {wybranaData:dd.MM.yyyy}";
            }
            else
            {
                Podsumowanie.Text = "Proszę wybrać datę.";
            }
        }
        }
}