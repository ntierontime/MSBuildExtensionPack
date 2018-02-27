using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.Organization
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPTabbedCommonOfOrganization : TabbedPage
    {
        public WPTabbedCommonOfOrganization()
        {
            InitializeComponent();
             BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM_Static;

        }
    }
}

