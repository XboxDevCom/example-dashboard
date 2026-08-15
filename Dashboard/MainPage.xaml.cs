using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Dashboard
{
    /// <summary>
    /// Die Hauptseite, die die SplitView-Navigation und den Inhalts-Frame enthält.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der MainPage-Klasse.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Wird aufgerufen, wenn zur Seite navigiert wird. Wählt standardmäßig die Startseite aus.
        /// </summary>
        /// <param name="e">Ereignisdaten für die Navigation.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            NavHome.IsSelected = true;
            ContentFrame.Navigate(typeof(Pages.HomePage));
        }

        /// <summary>
        /// Wird aufgerufen, wenn die Auswahl im Navigationsmenü geändert wird.
        /// </summary>
        /// <param name="sender">Die Quelle des Ereignisses.</param>
        /// <param name="e">Ereignisdaten für die Auswahländerung.</param>
        private void NavMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NavMenu.SelectedItem == null)
                return;

            var tag = (NavMenu.SelectedItem as ListViewItem).Tag as string;

            switch (tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(Pages.HomePage));
                    break;
                case "stats":
                    ContentFrame.Navigate(typeof(Pages.StatsPage));
                    break;
                case "settings":
                    ContentFrame.Navigate(typeof(Pages.SettingsPage));
                    break;
                case "about":
                    ContentFrame.Navigate(typeof(Pages.AboutPage));
                    break;
            }
        }
    }
}
