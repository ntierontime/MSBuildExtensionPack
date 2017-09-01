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

            //TODO: The following code can replace the "Load More" button. ItemAppearing event is not working properly in UWP, but working in Android emulator/Windows phone emulator, IOs not tested.
            //this.ResultView.ItemAppearing += (object sender, ItemVisibilityEventArgs e) => {
            //    var viewCellDetails = e.Item as MSBuildExtensionPack.DataSourceEntities.BuildEventCode;
            //    if (viewCellDetails == MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static.EntityCollection[MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static.EntityCollection.Count - 1])
            //    {
            //        MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static.LoadMoreCommand.Execute(null);
            //    }
            //};

            this.ResultView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                var viewCellDetails = e.Item as MSBuildExtensionPack.DataSourceEntities.BuildEventCode;
                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuildEventCode_Static.LaunchDetailsViewCommand.Execute(viewCellDetails);
            };

        }
    }
}

