using Prism.Commands;
using Prism.Navigation;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPrismTemplate.ViewModels
{
    public class GridDemoPageViewModel : ViewModelBase
    {
        public GridDemoPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Grid Demo Page";
        }
    }
}
