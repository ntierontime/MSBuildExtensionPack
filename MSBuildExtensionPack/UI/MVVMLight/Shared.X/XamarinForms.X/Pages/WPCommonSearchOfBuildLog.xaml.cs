﻿using System;
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
		public WPCommonSearchOfBuildLog()
		{
			InitializeComponent();
            BindingContext = MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_WPCommonOfBuildLogVM_Static;
            MSBuildExtensionPack.MVVMLightViewModels.ViewModelLocator.MSBuildExtensionPack_MVVMLightViewModels_ExtendedVMBuildLog_Static.InitializeTopLevelDropDownListContents();
        }
	}
}