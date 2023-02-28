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
            Xamarin.Forms.Extensions.Svg.SvgImage.ExceptionEvent += (sender, e) =>
            {
                var ex = ((Xamarin.Forms.Extensions.Svg.SvgImageExceptionEventArgs)e).SvgImageException;
                System.Diagnostics.Debug.WriteLine(ex.Message);
            };
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
