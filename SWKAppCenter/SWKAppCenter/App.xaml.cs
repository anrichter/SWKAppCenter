using System;
using System.Collections.Generic;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWKAppCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=5a84af21-2bda-4040-b05d-5f1bfd22a345;" +
                            "ios=c9dc5819-6a2e-4e48-8bc3-0a54f2c6f41b",
                typeof(Analytics), typeof(Crashes));
            Analytics.TrackEvent("App started...");


            try
            {
                throw new AccessViolationException("Tobi nervt...");
            }
            catch (Exception exception)
            {
                var x = new Dictionary<string, string> {{"Startup", "Tobi nervt Exceptio gefangen"}};
                Crashes.TrackError(exception, x);
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
