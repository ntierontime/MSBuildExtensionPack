using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.Build
{
    /// <summary>
    /// Interaction logic for WPxTabFullDetailsFK_BuildLog_BuildOfBuild.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPxTabFullDetailsFK_BuildLog_BuildOfBuild : ContentPage
    {
        public WPxTabFullDetailsFK_BuildLog_BuildOfBuild()
        {
            InitializeComponent();
             BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPxTabFullDetailsOfBuildVM_Static;

        }
    }
}

