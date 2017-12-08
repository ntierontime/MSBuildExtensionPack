using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages.Organization
{
    /// <summary>
    /// Interaction logic for WPCommonResultViewOfOrganization.xaml
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPCommonResultViewOfOrganization : ContentPage
    {
        public WPCommonResultViewOfOrganization()
        {
            InitializeComponent();

        BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM_Static;

            this.Appearing += (object sender, EventArgs e) => {
                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM_Static.SearchCommand.Execute(null);
            };

            //TODO: The following code can replace the "Load More" button. ItemAppearing event is not working properly in UWP, but working in Android emulator/Windows phone emulator, IOs not tested.
            //this.ResultView.ItemAppearing += (object sender, ItemVisibilityEventArgs e) => {
            //    var viewCellDetails = e.Item as MSBuildExtensionPack.DataSourceEntities.Organization.Default;
            //    if (viewCellDetails == MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM_Static.EntityCollection[MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM_Static.EntityCollection.Count - 1])
            //    {
            //        MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfOrganizationVM_Static.LoadMoreCommand.Execute(null);
            //    }
            //};

            this.ResultView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
                var viewCellDetails = e.Item as MSBuildExtensionPack.DataSourceEntities.Organization.Default;
                MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ItemVMOrganization_Static.LaunchDetailsViewCommand.Execute(viewCellDetails);
            };

        }
    }
}

