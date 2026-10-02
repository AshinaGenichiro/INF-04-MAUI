
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zadanie_12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void NumerOpuszczony(object sender, FocusEventArgs e)

        {

            string numer = poleNumer.Text;

            if (string.IsNullOrWhiteSpace(numer))

            {

                obrazZdjecie.Source = null;

                obrazOdcisk.Source = null;

                return;

            }



            obrazZdjecie.Source = numer + "–lada.jpg";

            obrazOdcisk.Source = numer + "–ae86.jpg";

        }
        private async void ZatwierdzDane(object sender, EventArgs e)

        {

            string imie = poleImie.Text;

            string nazwisko = poleNazwisko.Text;



            // Walidacja: imie i nazwisko musza byc wpisane 

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))

            {

                await DisplayAlert("Uwaga", "Wprowadz dane", "OK");

                return;

            }



            // Ustalamy zaznaczony kolor oczu na podstawie pol wyboru 

            string kolorOczu = PobierzKolorOczu();



            string komunikat = imie + " " + nazwisko + " kolor oczu " + kolorOczu;

            await DisplayAlert("Dane paszportowe", komunikat, "OK");

        }
        private string PobierzKolorOczu()

        {

            if (oczyNiebieskie.IsChecked)

                return "niebieskie";

            if (oczyZielone.IsChecked)

                return "zielone";



            return "piwne";

        }


    }
}
