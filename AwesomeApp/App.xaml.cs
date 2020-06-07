using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        int count = 0;
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;

            ((Button)sender).Text = $"You clicked {count} times.";
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        
    }
}
