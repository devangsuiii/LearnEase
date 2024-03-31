using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LearnEase
{
    public partial class VideosPage : ContentPage
    {
        public VideosPage()
        {
            InitializeComponent();
            BindingContext = new VideosPageViewModel();
        }
    }
   
}
