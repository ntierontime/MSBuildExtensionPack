using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin {
	public partial class MenuPage : ContentPage {
		public MenuPage() {
			BindingContext = new MenuPageViewModel();
			Title = "Menu";
            
			InitializeComponent();
		}
	}
}

