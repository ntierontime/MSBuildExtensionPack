using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MSBuildExtensionPack.XamarinForms {
	public class MenuPageViewModel {

		public ICommand GoHomeCommand { get; set; }
/*
		public ICommand GoSecondCommand { get; set; }
        public ICommand GoBuildLogCreateCommand { get; set; }
        public ICommand GoLaunchBuildEventCodeSearchCommand { get; set; }
		public ICommand GoLaunchBuildLogSearchCommand { get; set; }
*/
		public MenuPageViewModel() {
			GoHomeCommand = new Command(GoHome);
			//GoSecondCommand = new Command(GoSecond);
            //GoBuildLogCreateCommand = new Command(GoBuildLogCreate);
            //GoLaunchBuildEventCodeSearchCommand = new Command(GoLaunchBuildEventCodeSearch);
			//GoLaunchBuildLogSearchCommand = new Command(GoLaunchBuildLogSearch);
		}

        void GoHome(object obj)
        {
            App.NavigationPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

/*
        void GoSecond(object obj) {
			App.NavigationPage.Navigation.PushAsync(new SecondPage());
			App.MenuIsPresented = false;
		}


        void GoBuildLogCreate(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new Xamarin.Pages.BuildLog.Create());
            App.MenuIsPresented = false;
        }

        void GoLaunchBuildEventCodeSearch(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new Xamarin.Pages.WPCommonOfBuildEventCode());
            App.MenuIsPresented = false;
        }

		void GoLaunchBuildLogSearch(object obj)
		{
			App.NavigationPage.Navigation.PushAsync(new Xamarin.Pages.WPCommonOfBuildLog());
			App.MenuIsPresented = false;
		}
*/
	}
}

// https://github.com/srkrathore/AccordionEx
// https://www.codeproject.com/Articles/1088093/Simple-Accordion-User-Control-in-Xamarin-Forms
// https://github.com/Kimserey/AccordionView/blob/master/README.md
// https://github.com/alexrainman/CarouselView
// 