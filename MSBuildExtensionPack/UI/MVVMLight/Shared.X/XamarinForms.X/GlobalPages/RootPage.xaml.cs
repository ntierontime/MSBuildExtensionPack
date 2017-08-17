using Xamarin.Forms;

namespace MSBuildExtensionPack.XamarinForms.GlobalPages {
    public partial class RootPage : MasterDetailPage {
        public RootPage() {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;
        }
    }
}

