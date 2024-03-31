using Microsoft.Maui.Controls;

namespace LearnEase
{
    public partial class VideoPlayerPage : ContentPage
    {
        public VideoPlayerPage(string videoId)
        {
            InitializeComponent();

            // Load YouTube video with the given VideoId
            LoadYouTubeVideo(videoId);
        }

        private void LoadYouTubeVideo(string videoId)
        {
            // Construct the embed URL for the YouTube video
            string embedUrl = $"https://www.youtube.com/embed/{videoId}";

            // Load the YouTube video in the WebView control
            webView.Source = new UrlWebViewSource { Url = embedUrl };
        }
    }
}
