using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WPCommonOfBuildLog : ContentPage
	{
		public WPCommonOfBuildLog()
		{
			InitializeComponent();
			MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static.SearchCommand.Execute(null);
			this.BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static;
		}
	}
}