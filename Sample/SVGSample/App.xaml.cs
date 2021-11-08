using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SVGSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Xamarin.Forms.Extensions.Svg.SvgImage.RegisterAssembly();

            MainPage = new MainPage();
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
