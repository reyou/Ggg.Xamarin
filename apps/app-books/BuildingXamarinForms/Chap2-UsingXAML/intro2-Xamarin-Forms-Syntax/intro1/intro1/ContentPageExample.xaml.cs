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
        [ContentProperty("Text")]
        public class Label : View { }
        public ContentPageExample()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var b = sender as Button;
            await Task.Delay(TimeSpan.FromSeconds(2));
            b.Text = "It is so!";
        }
    }



}