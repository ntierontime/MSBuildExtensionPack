using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.Solution
{
    /// <summary>
    /// Interaction logic for WPCommonResultViewOfSolution.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPCommonResultViewOfSolution : ContentPage
    {
        public WPCommonResultViewOfSolution()
        {
            InitializeComponent();
             BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM_Static;

            this.Appearing += (object sender, EventArgs e) => {
                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM_Static.SearchCommand.Execute(null);
            };

            //TODO: The following code can replace the "Load More" button. ItemAppearing event is not working properly in UWP, but working in Android emulator/Windows phone emulator, IOs not tested.
            //this.ResultView.ItemAppearing += (object sender, ItemVisibilityEventArgs e) => {
            //    var viewCellDetails = e.Item as MSBuildExtensionPack.DataSourceEntities.Solution.Default;
            //    if (viewCellDetails == MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM_Static.Result[MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM_Static.EntityCollection.Count - 1])
            //    {
            //        MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfSolutionVM_Static.LoadMoreCommand.Execute(null);
            //    }
            //};

            this.ResultView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                var viewCellDetails = e.Item as MSBuildExtensionPack.DataSourceEntities.Solution.Default;
                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMSolution_Static.LaunchDetailsViewCommand.Execute(viewCellDetails);
            };

        }
    }
}

