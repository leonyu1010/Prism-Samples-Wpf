using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace NavigationParticipation.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Prism Unity Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand<string> NavigateCommand { get; private set; }
        public DelegateCommand<string> Navigate2Command { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            NavigateCommand = new DelegateCommand<string>(Navigate);
            Navigate2Command = new DelegateCommand<string>(Navigate2);
        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("DownRegion", navigatePath);
        }

        private void Navigate2(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("DownRegion", navigatePath);
        }
    }
}