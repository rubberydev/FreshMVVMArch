using System;
using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshMVVMArch
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
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
