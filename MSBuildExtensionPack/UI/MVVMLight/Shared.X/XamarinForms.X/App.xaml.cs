using System.Reflection;
using Xamarin.Forms;

namespace MSBuildExtensionPack.XamarinForms {
    public partial class App : Application {

        // *********************************************************************
        // TODO: wrap in a global Navigation Service (for example purposes only)
        // https://wolfprogrammer.com/2016/07/22/navigation-using-mvvm-light/
        public static NavigationPage NavigationPage { get; private set; }
        private static MSBuildExtensionPack.XamarinForms.GlobalPages.RootPage RootPage;
        public static bool MenuIsPresented {
            get {
                return RootPage.IsPresented;
            }
            set {
                RootPage.IsPresented = value;
            }
        }
        // *********************************************************************

        public App() {
            InitializeComponent();

            Assembly assembly = typeof(App).GetTypeInfo().Assembly;
            PCLAppConfig.ConfigurationManager.Initialise(assembly.GetManifestResourceStream("MSBuildExtensionPack.XamarinForms.ResourceApp.config"));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl = PCLAppConfig.ConfigurationManager.AppSettings[Framework.ViewModels.ApiControllerHttpClientBase.WebApiRootUrlAppSettingName];

            var menuPage = new MSBuildExtensionPack.XamarinForms.GlobalPages.MenuPage();
            NavigationPage = new NavigationPage(new MSBuildExtensionPack.XamarinForms.GlobalPages.HomePage());
            RootPage = new MSBuildExtensionPack.XamarinForms.GlobalPages.RootPage();
            RootPage.Master = menuPage;
            RootPage.Detail = NavigationPage;
            MainPage = RootPage;

            if (Device.RuntimePlatform.ToLower() == Framework.Xamariner.Platforms.iOS.ToString().ToLower() || Device.RuntimePlatform.ToLower() == Framework.Xamariner.Platforms.Android.ToString().ToLower())
            {
                // determine the correct, supported .NET culture
                var ci = DependencyService.Get<Framework.Xamariner.ILocalize>().GetCurrentCultureInfo();
                Framework.Resx.UIStringResource.Culture = ci; // set the RESX for resource localization
                MSBuildExtensionPack.Resx.UIStringResourcePerApp.Culture = ci; // set the RESX for resource localization

                MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuild.Culture = ci; // set the RESX for resource localization

                MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode.Culture = ci; // set the RESX for resource localization

                MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog.Culture = ci; // set the RESX for resource localization

                MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization.Culture = ci; // set the RESX for resource localization

                MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution.Culture = ci; // set the RESX for resource localization

                DependencyService.Get<Framework.Xamariner.ILocalize>().SetLocale(ci); // set the Thread for locale-aware methods
            }
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}

