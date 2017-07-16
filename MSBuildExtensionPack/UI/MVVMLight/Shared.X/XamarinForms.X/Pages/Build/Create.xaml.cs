using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.Build
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create : ContentPage
    {
        public Create()
        {
            InitializeComponent();
            BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild_Static.Item;
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuild_Static.GetDropDownContentsOfOrganization_2();
        }
    }
}

