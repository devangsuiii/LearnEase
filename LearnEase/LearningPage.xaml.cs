using Microsoft.Maui.Controls;


namespace LearnEase
{
    public partial class LearningPage : ContentPage
    {
        public LearningPage()
        {
            InitializeComponent();
        }
        private async void OnEnrollNowClicked_IntroToProgramming(object sender, EventArgs e)
        {
            // Navigate to a new page that shows details for the Introduction to Programming course
            var courseDetailPage = new CourseDetailPage("Introduction to Programming");
            await Navigation.PushAsync(courseDetailPage);
        }

        private async void OnEnrollNowClicked_AdvancedWebDev(object sender, EventArgs e)
        {
            // Navigate to a new page that shows details for the Advanced Web Development course
            var courseDetailPage = new CourseDetailPage("Advanced Web Development");
            await Navigation.PushAsync(courseDetailPage);
        }

        private async void OnEnrollNowClicked_DigitalMarketing(object sender, EventArgs e)
        {
            // Navigate to a new page that shows details for the Introduction to Programming course
            var courseDetailPage = new CourseDetailPage("Introduction to Digital Marketing");
            await Navigation.PushAsync(courseDetailPage);
        }

        private async void OnEnrollNowClicked_googleAds(object sender, EventArgs e)
        {
            // Navigate to a new page that shows details for the Advanced Web Development course
            var courseDetailPage = new CourseDetailPage("Advanced Google Ads");
            await Navigation.PushAsync(courseDetailPage);
        }
        private async void OnMoreClicked(object sender, EventArgs e)
        {
            await DisplayAlert("More Options", "This is the overflow menu", "OK");
        }
    }
}
