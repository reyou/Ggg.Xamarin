using System.ComponentModel;
using Xamarin.Forms;

namespace intro1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            // Feedback.Text = (string)Resources["FeedbackPlaceholder"];
            // Feedback.TextColor = (Color)Resources["InputPlaceholderColor"];
            Subject.Text = string.Empty;
            // Resources["PageBgColor"] = Resources["PageBgColorNoSubject"];
            // Resources["BtSubmitColor"] = Resources["BtInactiveColor"];
        }

        private void HandleFeedback(object sender, FocusEventArgs e)
        {

        }

        private void HandleSubject(object sender, FocusEventArgs e)
        {
            if (Subject.Text == string.Empty)
            {

            }
            else
            {

            }
        }
    }
}
