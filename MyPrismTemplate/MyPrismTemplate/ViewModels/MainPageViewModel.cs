using MyPrismTemplate.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPrismTemplate.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		private INavigationService _navigationService { get; }

		private string _lastUpdated;
		public string LastUpdated
		{
			get { return _lastUpdated; }
			set { SetProperty(ref _lastUpdated, value); }
		}

		public DelegateCommand NavigateToSpeakPageCommand { get; }

		public DelegateCommand NavigateToGridDemoPageCommand { get; }

		public DelegateCommand NavigateToWebViewDemoPageCommand { get; }

		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Main Page";
			LastUpdated = "Last Updated: " + DateTime.Now.ToShortDateString();

			_navigationService = navigationService;

			NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);
			NavigateToGridDemoPageCommand = new DelegateCommand(NavigateToGridDemoPage);
			NavigateToWebViewDemoPageCommand = new DelegateCommand(NavigateToWebViewDemoPage);
		}

		private void NavigateToSpeakPage()
		{
			_navigationService.NavigateAsync(nameof(SpeakPage));
		}
		private void NavigateToGridDemoPage()
		{
			_navigationService.NavigateAsync(nameof(GridDemoPage));
		}
		private void NavigateToWebViewDemoPage()
		{
			_navigationService.NavigateAsync(nameof(WebViewDemoPage));
		}
	}
}
