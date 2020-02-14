using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels
{
    public class ViewCViewModel : BindableBase, INavigationAware
    {
        private string _title = "ViewC";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private int _pageViews;

        public int PageViews
        {
            get { return _pageViews; }
            set { SetProperty(ref _pageViews, value); }
        }

        public ViewCViewModel()
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            PageViews++;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}