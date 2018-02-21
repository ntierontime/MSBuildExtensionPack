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
    /// Interaction logic for WPsomethingSearchOfBuild.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPsomethingSearchOfBuild : ContentPage
    {
        public WPsomethingSearchOfBuild()
        {
            InitializeComponent();

        BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPsomethingOfBuildVM_Static;

        }
    }
}

