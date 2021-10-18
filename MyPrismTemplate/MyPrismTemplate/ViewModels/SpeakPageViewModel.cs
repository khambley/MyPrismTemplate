using Prism.Commands;
using Prism.Navigation;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPrismTemplate.ViewModels
{
	public class SpeakPageViewModel : ViewModelBase //BindableBase
	{
		private string _textToSay = "Hello Prism";
		public string TextToSay
		{
			get => _textToSay;
			set => SetProperty(ref _textToSay, value);
		}

		public DelegateCommand SpeakCommand { get; }

		public SpeakPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Speak Page";
			SpeakCommand = new DelegateCommand(Speak);
		}
		private void Speak()
		{
			// TODO: call service
		}
	}
}
