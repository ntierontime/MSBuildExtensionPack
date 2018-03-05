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
    /// Interaction logic for WPxTabFullDetailsAncestorsSolution_1OfBuild.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPxTabFullDetailsAncestorsSolution_1OfBuild : ContentPage
    {
        public WPxTabFullDetailsAncestorsSolution_1OfBuild()
        {
            InitializeComponent();
             BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPxTabFullDetailsOfBuildVM_Static;

        }
    }
}

