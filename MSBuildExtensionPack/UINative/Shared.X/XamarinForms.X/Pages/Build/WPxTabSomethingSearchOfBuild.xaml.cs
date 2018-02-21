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
    /// Interaction logic for WPxTabSomethingSearchOfBuild.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPxTabSomethingSearchOfBuild : ContentPage
    {
        public WPxTabSomethingSearchOfBuild()
        {
            InitializeComponent();

        BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPxTabSomethingOfBuildVM_Static;

        }
    }
}

