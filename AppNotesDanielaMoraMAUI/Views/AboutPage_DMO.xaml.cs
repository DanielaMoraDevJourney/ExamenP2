namespace AppNotesDanielaMoraMAUI.Views
{
    public partial class AboutPage_DMO : ContentPage
    {
        public AboutPage_DMO()
        {
            InitializeComponent();
        }

        private async void LearnMore_Clicked_DMO(object sender, EventArgs e)
        {
            if (BindingContext is Models.About_DMO about)
            {
                // Navigate to the specified URL in the system browser.
                await Launcher.Default.OpenAsync(about.MoreInfoUrl_DMO);
            }
        }
    }
}
