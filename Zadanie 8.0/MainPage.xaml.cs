
using System.ComponentModel.Design;

namespace Zadanie_8._0
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void Clicekd(object sender, EventArgs e)
        {
            if(int.TryParse(AgeEntry.Text, out int age))
            {
                if (age > 0 && age < 120)
                {
                   DisplayAlert("Wiek", $"Twój wiek to: {age}", "OK");
                }
                else
                {
                    DisplayAlert("Błąd", "Wiek musi byc z zakresu 1-120", "OK");

                }
            }
            else
            {
                DisplayAlert("Błąd", "Podaj wiek jako liczbe ...", "OK");
            }
           
        }


    }
}
