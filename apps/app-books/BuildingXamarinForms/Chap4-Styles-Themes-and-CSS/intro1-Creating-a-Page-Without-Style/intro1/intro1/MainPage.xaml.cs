using System.ComponentModel;
using Xamarin.Forms;

namespace intro1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        const string placeHolderText = "Type your message here";
        public MainPage()
        {
            InitializeComponent();
            Feedback.Text = placeHolderText;
        }

        private void HandleFeedback(object sender, FocusEventArgs e)
        {
            string text = Feedback.Text;
            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                return;
            }
            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                return;
            }
        }
    }
}
