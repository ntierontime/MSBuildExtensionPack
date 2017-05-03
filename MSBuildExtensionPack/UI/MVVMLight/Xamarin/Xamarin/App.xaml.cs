using System.Reflection;
using Xamarin.Forms;

namespace Xamarin {
	public partial class App : Application {

		// *********************************************************************
		// TODO: wrap in a global Navigation Service (for example purposes only)
		// https://wolfprogrammer.com/2016/07/22/navigation-using-mvvm-light/
		public static NavigationPage NavigationPage { get; private set; }
		private static RootPage RootPage;
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
            PCLAppConfig.ConfigurationManager.Initialise(assembly.GetManifestResourceStream("Xamarin.ResourceApp.config"));
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.WebApiRootUrl = PCLAppConfig.ConfigurationManager.AppSettings[Framework.ViewModels.ApiControllerHttpClientBase.WebApiRootUrlAppSettingName];

            var menuPage = new MenuPage();
			NavigationPage = new NavigationPage(new HomePage());
			RootPage = new RootPage();
			RootPage.Master = menuPage;
			RootPage.Detail = NavigationPage;
			MainPage = RootPage;

            if (Device.RuntimePlatform.ToLower() == Platforms.iOS.ToString().ToLower() || Device.RuntimePlatform.ToLower() == Platforms.Android.ToString().ToLower())
            {
                // determine the correct, supported .NET culture
                var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                Framework.Resources.UIStringResource.Culture = ci; // set the RESX for resource localization
                MSBuildExtensionPack.Resources.UIStringResourcePerApp.Culture = ci; // set the RESX for resource localization
                MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild.Culture = ci; // set the RESX for resource localization
                MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildEventCode.Culture = ci; // set the RESX for resource localization
                MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuildLog.Culture = ci; // set the RESX for resource localization
                MSBuildExtensionPack.Resources.UIStringResourcePerEntitySolution.Culture = ci; // set the RESX for resource localization
                DependencyService.Get<ILocalize>().SetLocale(ci); // set the Thread for locale-aware methods
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

