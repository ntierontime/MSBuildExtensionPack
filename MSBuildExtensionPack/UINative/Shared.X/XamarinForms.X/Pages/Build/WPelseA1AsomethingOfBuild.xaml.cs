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
    /// Interaction logic for WPelseA1AsomethingOfBuild.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPelseA1AsomethingOfBuild : ContentPage
    {
        public WPelseA1AsomethingOfBuild()
        {
            InitializeComponent();
             BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPelseA1AsomethingOfBuildVM_Static;

        }
    }
}

