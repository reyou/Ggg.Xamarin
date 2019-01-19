using System;
using Xamarin.Forms;

namespace intro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "Hello World!", "Cancel");
        }
    }
}
