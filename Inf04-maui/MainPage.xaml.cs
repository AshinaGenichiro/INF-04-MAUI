namespace Inf04_maui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClearButtonClicked(object? sender, EventArgs e)
        {
            phoneNumberEntry.Text = string.Empty;
            emailEntry.Text = string.Empty;

        }
    }
}
