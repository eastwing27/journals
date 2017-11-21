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
        public static JournalsService Journals { get; internal set; }

        //Platform-specific methods and attributes.
        public static Action<string> Notify { get; private set; }

        public App(Natives Natives)
        {
            InitializeComponent();

            Journals = new JournalsService();

            Notify = Natives.Notify;

            MainPage = new Journals.App.MainPage();
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
