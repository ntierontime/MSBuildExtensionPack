using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode
{
    /// <summary>
    /// Interaction logic for WPCommonSearchViewOfBuildEventCode.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPCommonSearchViewOfBuildEventCode : ContentPage
    {
        public WPCommonSearchViewOfBuildEventCode()
        {
            InitializeComponent();

        BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static;

        }
    }
}

