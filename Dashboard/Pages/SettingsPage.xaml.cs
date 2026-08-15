using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Dashboard.Pages
{
    /// <summary>
    /// Einstellungsseite mit Steuerelementen für Design, Sounds, Schriftgröße und Sprache.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der SettingsPage-Klasse.
        /// </summary>
        public SettingsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Wird aufgerufen, wenn der Dunkelmodus-Schalter umgeschaltet wird.
        /// </summary>
        /// <param name="sender">Die Quelle des Ereignisses.</param>
        /// <param name="e">Ereignisdaten für das Umschalten.</param>
        private void DarkModeToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (DarkModeToggle.IsOn)
            {
                this.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Black);
            }
            else
            {
                this.Background = (Windows.UI.Xaml.Media.Brush)Application.Current.Resources["ApplicationPageBackgroundThemeBrush"];
            }
        }

        /// <summary>
        /// Wird aufgerufen, wenn der UI-Sounds-Schalter umgeschaltet wird.
        /// </summary>
        /// <param name="sender">Die Quelle des Ereignisses.</param>
        /// <param name="e">Ereignisdaten für das Umschalten.</param>
        private void SoundToggle_Toggled(object sender, RoutedEventArgs e)
        {
            if (SoundToggle.IsOn)
            {
                ElementSoundPlayer.State = ElementSoundPlayerState.On;
            }
            else
            {
                ElementSoundPlayer.State = ElementSoundPlayerState.Off;
            }
        }
    }
}
