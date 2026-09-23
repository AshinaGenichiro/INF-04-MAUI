namespace Zadanie_5
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void onValueChange(object? sender, EventArgs e)
        {
                Grade.Text = $"Ocena: {Math.Round(GradeSlider.Value)}";


        }
    }
}
