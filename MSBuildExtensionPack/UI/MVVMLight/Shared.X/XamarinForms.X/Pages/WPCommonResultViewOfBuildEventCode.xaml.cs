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
    /// https://github.com/shribits/ListViewPagingAndCaching
    /// http://motzcod.es/post/107620279512/load-more-items-at-end-of-listview-in
    /// https://stackoverflow.com/questions/43102069/xamarin-forms-listview-load-more
    /// https://forums.xamarin.com/discussion/83427/xamarin-forms-recycled-listview-with-infinite-scrolling
    /// https://github.com/rasmuschristensen/SimpleListViewInfiniteScrolling
    /// </summary>
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WPCommonResultViewOfBuildEventCode : ContentPage
    {
        public WPCommonResultViewOfBuildEventCode()
        {
            InitializeComponent();


		BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static;

		MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildEventCodeVM_Static.SearchCommand.Execute(null);























        }
    }
}

