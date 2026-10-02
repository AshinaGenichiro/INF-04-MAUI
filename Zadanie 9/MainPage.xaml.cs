using System.Collections.ObjectModel;

namespace Zadanie_9
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private ObservableCollection<string> zadania = new ObservableCollection<string>();
        public MainPage()
        {
            InitializeComponent();
            lista.ItemsSource = zadania;
        }

        private void AddTask(object? sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(ListEntry.Text))
            {
                zadania.Add(ListEntry.Text);
                ListEntry.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Błąd", "Proszę wpisać zadanie.", "OK");
            }
            ResultLabel.Text = $"Liczba zadań: {zadania.Count}";
        }

        private void RemoveTask(object? sender, EventArgs e)
        {
            if (lista.SelectedItem == null)
            {
            
                return;
            }
            string zaznaczone = (string)lista.SelectedItem;
            zadania.Remove(zaznaczone);
            ResultLabel.Text = $"Liczba zadań: {zadania.Count}";

        }
    }
}
