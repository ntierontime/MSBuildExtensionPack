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
    /// Interaction logic for WPCommonResultViewOfBuildLog.xaml
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPCommonResultViewOfBuildLog : ContentPage
    {
        public WPCommonResultViewOfBuildLog()
        {
            InitializeComponent();


		BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static;

		MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static.SearchCommand.Execute(null);























        }
    }
}

