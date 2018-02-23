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
    public partial class xTabFullDetailsRelatedEntityWhenMasterViewIsFKEntity : ContentPage
    {
        public xTabFullDetailsRelatedEntityWhenMasterViewIsFKEntity()
        {
            BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPxTabFullDetailsOfBuildVM_Static;
            InitializeComponent();
        }
    }
}