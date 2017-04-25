using Xamarin.Forms;

namespace Xamarin {
	public partial class RootPage : MasterDetailPage {
		public RootPage() {
			InitializeComponent();
			MasterBehavior = MasterBehavior.Popover;
		}
	}
}

