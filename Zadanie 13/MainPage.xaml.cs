using System.Text.RegularExpressions;
namespace Zadanie_13
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnCheckPriceButtonClicked(object sender, EventArgs e)
        {
            if(Pocztówka.IsChecked)
            {
                Price.Text = "Cena: 1 zł";
                parcelPhoto.Source = "pocztowka.jpg";
            }
            if(List.IsChecked)
            {
                Price.Text = "Cena: 2 zł";
                parcelPhoto.Source = "list.jpg";
            }
            if(Paczka.IsChecked)
            {
                Price.Text = "Cena: 10 zł";
                parcelPhoto.Source = "paczka.jpg";
            }
            if(Polecony.IsChecked)
            {
                Price.Text = "Cena: 3 zł";
                parcelPhoto.Source = "polecony.jpg";
            }


        }
        private void onConfirmButtonClicked(object sender, EventArgs e)
        {
            string wzorKodu = @"^\d{2}-\d{3}$"; // Kod zrobiony z ai, 
          if (!string.IsNullOrWhiteSpace(KodPocztowy.Text) && Regex.IsMatch(KodPocztowy.Text, wzorKodu) && !string.IsNullOrWhiteSpace(Ulica.Text) && !string.IsNullOrWhiteSpace(Miasto.Text))
          {
            DisplayAlert("Potwierdzenie", "Dane przesyłki zostły wprowadzone", "OK");
          }
          else
          {
            DisplayAlert("Błąd", "Proszę wpisać poprawny kod pocztowy, musi sie składać z samych cyfr(schemat to 22-400)", "OK");
          }
        }


    }
}
