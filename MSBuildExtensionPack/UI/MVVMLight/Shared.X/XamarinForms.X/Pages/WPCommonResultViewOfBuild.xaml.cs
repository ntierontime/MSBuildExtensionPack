using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages
{
    /// <summary>
    /// Interaction logic for WPCommonResultViewOfBuild.xaml
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPCommonResultViewOfBuild : ContentPage
    {
        public WPCommonResultViewOfBuild()
        {
            InitializeComponent();


		BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM_Static;























        }
    }
}

