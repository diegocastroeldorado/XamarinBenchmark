using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PerformanceTestForms
{
    public partial class App : Application
    {
        public App()
        {
            Debug.WriteLine(string.Format("[{0}]: {1}", DateTime.Now.Millisecond, "#### Started App"));

            InitializeComponent();

            MainPage = new PerformanceTestForms.MainPage();
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
