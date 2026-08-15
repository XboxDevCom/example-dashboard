using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Dashboard.Pages
{
    /// <summary>
    /// Infoseite mit App-Details, Lizenz und Urheberrechtshinweis.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der AboutPage-Klasse.
        /// </summary>
        public AboutPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Wird aufgerufen, wenn auf die Schaltfläche „Lizenz anzeigen" geklickt wird.
        /// </summary>
        /// <param name="sender">Die Quelle des Ereignisses.</param>
        /// <param name="e">Ereignisdaten für den Klick.</param>
        private void ShowLicense_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ContentDialog
            {
                Title = "MIT-Lizenz",
                Content = "Copyright © 2018 XboxDev\n\nDiese Software wird unter der MIT-Lizenz bereitgestellt.",
                CloseButtonText = "Schließen"
            };
            _ = dialog.ShowAsync();
        }
    }
}
