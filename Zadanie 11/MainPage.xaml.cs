

using System.Collections.ObjectModel;

namespace Zadanie_11
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> kolory = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            colorHistoryCollection.ItemsSource = kolory;
        }

     public void ButtonClicked(object sender, EventArgs e)
        {
            int RedSliderValue = (int)RedSlider.Value;
            int GreenSliderValue = (int)GreenSlider.Value;
            int BlueSliderValue = (int)BlueSlider.Value;
            showColorLabel.Text = $"{RedSliderValue}, {GreenSliderValue}, {BlueSliderValue}"; 
            showColorLabel.BackgroundColor = Color.FromRgb(RedSliderValue, GreenSliderValue, BlueSliderValue);
            kolory.Add($"{RedSliderValue}, {GreenSliderValue}, {BlueSliderValue}");
        }
        public void onSliderChanged(object sender, ValueChangedEventArgs e)
        {
            int RedSliderValue = (int)RedSlider.Value;
            int GreenSliderValue = (int)GreenSlider.Value;
            int BlueSliderValue = (int)BlueSlider.Value;
            showColorBox.Color = Color.FromRgb(RedSliderValue, GreenSliderValue, BlueSliderValue);
            showColorHexLabel.Text = $"#{RedSliderValue:X2}{GreenSliderValue:X2}{BlueSliderValue:X2}";
        }
    }
}
