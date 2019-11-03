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


    }



}