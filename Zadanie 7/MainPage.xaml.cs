namespace Zadanie_7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCornsilkButtonClicked(object? sender, EventArgs e)
        {
            this.BackgroundColor = Color.FromArgb("#FFF8DC");
            CurrentColor.Text = $"Aktuany kolor: Cornsilk (#FFF8DC)";
        }
        private void OnPeruButtonClicked(object? sender, EventArgs e)
        {
            this.BackgroundColor = Color.FromArgb("#CD853F");
            CurrentColor.Text = $"Aktuany kolor: Peru (#CD853F)";

        }
    }
}
