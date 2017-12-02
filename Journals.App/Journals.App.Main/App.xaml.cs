using Journals.App.Pages;
using Journals.App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Journals.App
{
    public partial class App : Application
    {
        internal static INative Native { get; private set; }
        internal static JournalsService Journals { get; private set; }

        public App()
        {
            InitializeComponent();

            Native = DependencyService.Get<INative>();
            Journals = new JournalsService();

            MainPage = new MainPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
