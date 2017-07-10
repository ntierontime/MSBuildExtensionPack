using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Threading;

namespace MSBuildExtensionPack.AndroidApp
{
    [Activity(Label = "MSBuildExtensionPack.AndroidApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
			Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule())
					  .With(new Plugin.Iconize.Fonts.MaterialModule())
					  .With(new Plugin.Iconize.Fonts.MeteoconsModule())
					  .With(new Plugin.Iconize.Fonts.TypiconsModule());
			TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<Framework.Xaml.IDispatcherHelperWrapper, MSBuildExtensionPack.AndroidApp.DispatcherHelperWrapper>();
            DispatcherHelper.Initialize();

            global::Xamarin.Forms.Forms.Init(this, bundle);

			FormsPlugin.Iconize.Droid.IconControls.Init(Resource.Id.toolbar, Resource.Id.sliding_tabs);
			//PCLAppConfig.ConfigurationManager.Initialise(PCLAppConfig.FileSystemStream.PortableStream.Current);

			LoadApplication(new MSBuildExtensionPack.XamarinForms.App());
        }
	}
}

