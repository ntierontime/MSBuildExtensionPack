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
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //DispatcherHelper.Initialize();
            Framework.IoCContainerWrapperSingleton.Instance.IoCContainer.Register<Framework.Xaml.IDispatcherHelperWrapper, MSBuildExtensionPack.AndroidApp.DispatcherHelperWrapper>();

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //PCLAppConfig.ConfigurationManager.Initialise(PCLAppConfig.FileSystemStream.PortableStream.Current);

            LoadApplication(new MSBuildExtensionPack.XamarinForms.App());
        }
    }
}

