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
    /// Interaction logic for WPxTabFullDetailsAncestorsOrganization_2OfBuild.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPxTabFullDetailsAncestorsOrganization_2OfBuild : ContentPage
    {
        public WPxTabFullDetailsAncestorsOrganization_2OfBuild()
        {
            InitializeComponent();
             BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPxTabFullDetailsOfBuildVM_Static;

        }
    }
}

