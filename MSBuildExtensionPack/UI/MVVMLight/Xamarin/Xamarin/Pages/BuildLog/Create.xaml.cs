using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Pages.BuildLog
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Create : ContentPage
    {
        public Create()
        {
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.GetDropDownContentsOfSolution_1();
            InitializeComponent();
            BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildLog_Static.Item;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void FocusDatePicker(DatePicker obj)
        {
            obj.Focus();
        }
        private void SetDateOfBirth()
        {
            //DateOfBirth = SelectedDOB;
        }
    }
}

// http://stackoverflow.com/questions/37477860/datepicker-how-to-popup-datepicker-when-click-on-edittext-using-c-sharp-xamarin