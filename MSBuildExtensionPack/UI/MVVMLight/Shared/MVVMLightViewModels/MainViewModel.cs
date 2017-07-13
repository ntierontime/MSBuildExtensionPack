using System;
using System.Collections.Concurrent;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace MSBuildExtensionPack.MVVMLightViewModels
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm/getstarted
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the page instance singleton.
        /// For Xamarin.Forms
        /// Not for WPF
        /// </summary>
        /// <value>
        /// The page instance singleton.
        /// </value>
        ConcurrentDictionary<Type, object> PageInstanceSingleton { get; set; }

		public bool QuitConfirmationEnabled { get; set; }
        public bool IsBusy { get; set; }

        public string Welcome
        {
            get
            {
                return Framework.Resx.UIStringResource.Common_WelcomeToNTIERONTIME;
            }
        }

        public Framework.Xaml.MenuTreeItem MainMenuTree { get; set; }

        public Framework.MenuTreeItem m_SelectedMenuTreeItem;
        public Framework.MenuTreeItem SelectedMenuTreeItem { 
            get
            {
                return this.m_SelectedMenuTreeItem;
            }
            set 
            {
                this.m_SelectedMenuTreeItem = value;
                RaisePropertyChanged("SelectedMenuTreeItem");
            }
        }

        public RelayCommand MenuItemSelectedCommand { get; private set; }

        public void MenuItemSelected()
        {
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(this.SelectedMenuTreeItem.SourceTypeFullName, this.SelectedMenuTreeItem.SenderView, this.SelectedMenuTreeItem.UIAction, this.SelectedMenuTreeItem.UIActionStatus));
        }

		
        public RelayCommand<Framework.MenuTreeItem> MenuItemSelectedCommandTyped { get; private set; }
        public void MenuItemSelectedTyped(Framework.MenuTreeItem selectedMenuTreeItem)
        {
            Messenger.Default.Send<Framework.UIActionStatusMessage>(new Framework.UIActionStatusMessage(selectedMenuTreeItem.SourceTypeFullName, selectedMenuTreeItem.SenderView, selectedMenuTreeItem.UIAction, selectedMenuTreeItem.UIActionStatus));
        }

        public Framework.NavigationSettingCollection NavigationSettingCollection { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
            }

			//#region 1. Initialize Menu

			this.MainMenuTree = new Framework.Xaml.MenuTreeItem();

			//#endregion 1. Initialize Menu

            //#region 2. Initialize NavigationSettingCollection

            this.NavigationSettingCollection = new Framework.NavigationSettingCollection();

            //#endregion 2. Initialize NavigationSettingCollection

            //#region 3. Initialize MenuItemSelectedCommand

            this.MenuItemSelectedCommand = new RelayCommand(MenuItemSelected);
            this.MenuItemSelectedCommandTyped = new RelayCommand<Framework.MenuTreeItem>(MenuItemSelectedTyped);

            //#endregion 3. Initialize MenuItemSelectedCommand

            PageInstanceSingleton = new ConcurrentDictionary<Type, object>();

            this.IsBusy = false;
        }

        public object GetPageInstanceSingleton(Type pageType)
        {
            if(PageInstanceSingleton.ContainsKey(pageType))
                return PageInstanceSingleton[pageType];

            try
            {
                return Activator.CreateInstance(pageType);
            }
            catch
            {
                return null;
            }
        }

        //public override void Cleanup()
        //{
        //    // Clean up if needed
        //
        //    base.Cleanup();
        //}
    }
}

