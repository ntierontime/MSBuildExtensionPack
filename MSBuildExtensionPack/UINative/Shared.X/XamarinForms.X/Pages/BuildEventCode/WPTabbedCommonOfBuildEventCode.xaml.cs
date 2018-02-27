using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.BuildEventCode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPTabbedCommonOfBuildEventCode : TabbedPage
    {
        public WPTabbedCommonOfBuildEventCode()
        {
            InitializeComponent();
             BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static;

        }
    }
}

