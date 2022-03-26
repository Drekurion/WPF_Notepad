using System.Windows.Input;

namespace WPF_Notepad.ViewModels
{
	public class HelpViewModel : ObservableObject
	{
		public ICommand HelpCommand { get; }

		public HelpViewModel()
		{
			HelpCommand = new RelayCommand(DisplayAbout);
		}

		private void DisplayAbout()
		{
			//We will open help dialog
		}
	}
}
