using Prism.Commands;
using Prism.Navigation;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPrismTemplate.ViewModels
{
    public class WebViewDemoPageViewModel : ViewModelBase
    {
        public WebViewDemoPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "WebView Demo Page";
        }
    }
}
