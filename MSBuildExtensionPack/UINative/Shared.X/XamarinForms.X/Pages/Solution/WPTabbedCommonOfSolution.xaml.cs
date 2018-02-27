using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.Solution
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPTabbedCommonOfSolution : TabbedPage
    {
        public WPTabbedCommonOfSolution()
        {
            InitializeComponent();
             BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM_Static;

        }
    }
}

