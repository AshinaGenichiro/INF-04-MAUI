namespace Zadanie_2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onCityButtonClicked(object? sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(CityEntry.Text) && !string.IsNullOrWhiteSpace(NameEntry.Text))
                {
                    ResultLabel.Text = $"Witaj {NameEntry.Text} z miasta {CityEntry.Text}";
                }
                else
                {
                 ResultLabel.Text = "Uzupełnij oba pola";
                }
        }
    }
}
