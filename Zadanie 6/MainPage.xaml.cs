namespace Zadanie_6
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderChange(object? sender, EventArgs e)
        {
            ValueLabel.Text = $"Obecna Wartosc: {Math.Round(ValueSlider.Value)}";
            if(ValueSlider.Value < 128)
            {
                ResultLabel.Text = "Mało";
            }else
            {
                ResultLabel.Text = "Dużo";

            }
        }
    }
}
