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
    public partial class xTabFullDetailsMasterViewAsideKeyInformation : ContentPage
    {
        public xTabFullDetailsMasterViewAsideKeyInformation()
        {
            BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPxTabFullDetailsOfBuildVM_Static;

            InitializeComponent();
        }
    }
}