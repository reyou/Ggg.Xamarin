using Xamarin.Forms;

namespace intro1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        /// <summary>
        /// Called when the app is first started. Useful for loading
        /// values into memory that are needed by the app.
        /// </summary>
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        /// <summary>
        /// Called each time the app is moved into the background.
        /// Useful for cleanup and initiating background calls.
        /// OnSleep is also used for normal application termination (not a crash).
        /// Any time an app moves into a background state, it must be assumed
        /// that it may never return from that state.
        /// </summary>
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        /// <summary>
        /// Called when the app is resumed after being in the
        /// background. Useful for reloading values into memory and returning
        /// from background threads.
        /// </summary>
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
