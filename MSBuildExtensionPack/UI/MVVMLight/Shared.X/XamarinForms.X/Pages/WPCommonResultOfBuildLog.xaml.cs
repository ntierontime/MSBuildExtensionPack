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
	public partial class WPCommonResultOfBuildLog : ContentPage
	{
		public WPCommonResultOfBuildLog()
		{
			InitializeComponent();
			MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator
				.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static.SearchCommand.Execute(null);
			BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static;
		}
	}
}