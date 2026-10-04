
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



            obrazZdjecie.Source = "lada_" + numer + ".jpg";
            obrazOdcisk.Source = "ae86_" + numer + ".jpg";

        }
        private async void ZatwierdzDane(object sender, EventArgs e)
        {
            string numer = poleNumer.Text;
            string imie = poleImie.Text;
            string nazwisko = poleNazwisko.Text;

     
            if (string.IsNullOrWhiteSpace(numer))
            {
                await DisplayAlert("Uwaga", "Wprowadź numer", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
            {
                await DisplayAlert("Uwaga", "Wprowadź dane", "OK");
                return;
            }

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

            if (oczyPiwne.IsChecked)
                return "piwne";

            if (oczySzare.IsChecked)
                return "szare";

            return "niebieskie";
        }
        private void WyczyscDane(object sender, EventArgs e)
        {
            
            poleNumer.Text = "";
            poleImie.Text = "";
            poleNazwisko.Text = "";

 
            oczyNiebieskie.IsChecked = true;

            obrazZdjecie.Source = null;
            obrazOdcisk.Source = null;
        }


    }
}
