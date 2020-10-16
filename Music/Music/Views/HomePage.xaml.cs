using Plugin.Segmented.Control;
using Plugin.Segmented.Event;
using Music.ViewModel;
using Xamarin.Forms;

namespace Music.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
           
            InitializeComponent();
            BindingContext = new HomePageViewModel(Navigation);
           
        }

       
    }
}
