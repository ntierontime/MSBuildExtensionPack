using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.Build
{
    /// <summary>
    /// Interaction logic for WPCommonResultViewOfBuild.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPCommonResultViewOfBuild : ContentPage
    {
        public WPCommonResultViewOfBuild()
        {
            InitializeComponent();

        BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM_Static;

            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM_Static.SearchCommand.Execute(null);

            //TODO: The following code can replace the "Load More" button. ItemAppearing event is not working properly in UWP, but working in Android emulator/Windows phone emulator, IOs not tested.
            //this.ResultView.ItemAppearing += (object sender, ItemVisibilityEventArgs e) => {
            //    var viewCellDetails = e.Item as MSBuildExtensionPack.DataSourceEntities.Build.Default;
            //    if (viewCellDetails == MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM_Static.EntityCollectionDefault[MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM_Static.EntityCollectionDefault.Count - 1])
            //    {
            //        MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildVM_Static.LoadMoreCommand.Execute(null);
            //    }
            //};

            this.ResultView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                var viewCellDetails = e.Item as MSBuildExtensionPack.DataSourceEntities.Build.Default;
                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMBuild_Static.LaunchDetailsViewCommand.Execute(viewCellDetails);
            };

        }
    }
}

