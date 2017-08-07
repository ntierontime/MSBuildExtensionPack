using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MSBuildExtensionPack.XamarinForms.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WPCommonSearchOfBuildLog : ContentPage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WPCommonSearchOfBuildLog"/> class.
		/// http://motzcod.es/post/94643411707/enhancing-xamarinforms-listview-with-grouping
		/// </summary>
		public WPCommonSearchOfBuildLog()
		{
			InitializeComponent();
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static.SearchCommand.Execute(null);
            BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static;
        }
	}
}