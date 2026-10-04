namespace Zadanie_1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onChangeGreetingsClicked(object? sender, EventArgs e)
        {
           titleLabel.Text = "Aplikacja działa poprawnie";
        }
        private void OnResetButtonClicked(object sender, EventArgs e)
        {
            titleLabel.Text = "Witamy w aplikacji";
        }
    }
}
