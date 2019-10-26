using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace intro1
{
    /// <summary>
    /// Attribute that controls whether XAML will be compiled at build time or run time.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "It is so! " + DateTime.Now.ToString("T");
        }

        private async void ImageTapped(object sender, EventArgs e)
        {
            Image image = ((Image)sender);
            await image.FadeTo(0.5, 450);
            await Task.Delay(1000);
            await image.FadeTo(1, 450);
        }

    }
}