using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MSBuildExtensionPack.XamarinForms.GlobalPages {
    public partial class MenuPage : ContentPage {
        public MenuPage() {
            BindingContext = new MSBuildExtensionPack.XamarinForms.MenuPageViewModel();
            Title = Framework.Resx.UIStringResource.Menu;
            InitializeComponent();
        }
    }
}

