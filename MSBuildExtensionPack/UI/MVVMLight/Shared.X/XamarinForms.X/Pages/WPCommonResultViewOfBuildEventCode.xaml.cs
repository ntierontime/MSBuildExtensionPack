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
    /// Interaction logic for WPCommonResultViewOfBuildEventCode.xaml
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPCommonResultViewOfBuildEventCode : ContentPage
    {
        public WPCommonResultViewOfBuildEventCode()
        {
            InitializeComponent();


		BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static;

		MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static.SearchCommand.Execute(null);























        }
    }
}

