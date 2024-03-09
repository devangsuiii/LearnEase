using Microsoft.Maui.Controls;


namespace LearnEase
{
    public partial class LearningPage : ContentPage
    {
        public LearningPage()
        {
            InitializeComponent();
        }

        private async void OnMoreClicked(object sender, EventArgs e)
        {
            await DisplayAlert("More Options", "This is the overflow menu", "OK");
        }
    }
}
