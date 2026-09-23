namespace Zadanie_4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSingInButtonClicked(object? sender, EventArgs e)
        {
            string isSwitchToggled, isCheckboxChecked,courseForm;
            if(CertyficateSwitch.IsToggled)
            {
                isSwitchToggled = "Zaznaczono pole wiedzy";
            }
            else
            {
                isSwitchToggled = "nie zaznaczono pola wiedzy"; 
            }

            if (BasicKnowledge.IsChecked)
            {
                isCheckboxChecked = "właczono przełącznik certyfikatu ";
            }
            else
            {
                isCheckboxChecked = "wyłączono przełącznik certyfikatu";
            }
            if (opcjaStacjonarny.IsChecked)
            {
                courseForm = "stacjonarny";
            }
            else if (opcjaOnline.IsChecked)
            {
                courseForm = "Online";
            }
            else
            {
                courseForm = "Hybrydowy";
            }

            if (!string.IsNullOrWhiteSpace(NameEntry.Text) && !string.IsNullOrWhiteSpace(SurnameEntry.Text))
            {
     
                SummaryLabel.Text = $"Imię: {NameEntry.Text} Nazwisko : {SurnameEntry.Text} Certyfikat: {isCheckboxChecked}, Pole wiedzy: {isSwitchToggled}, forma kursu :{courseForm}  oczekiwana uzytkownia : {userExpectations.Text} ";
            }else
            {
                SummaryLabel.Text = "Prosze o uzupełnienie imienia i nazwiska ";
            }
        }
    }
}
