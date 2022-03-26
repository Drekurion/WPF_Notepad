using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Notepad.ViewModels
{
	public class EditViewModel : ObservableObject
	{
		public ICommand UndoCommand { get; }
		public ICommand RedoCommand { get; }
		public ICommand CutCommand { get; }
		public ICommand CopyCommand { get; }
		public ICommand PasteCommand { get; }

		public EditViewModel()
		{
			UndoCommand = ApplicationCommands.Undo;
			RedoCommand = ApplicationCommands.Redo;
			CutCommand = ApplicationCommands.Cut;
			CopyCommand = ApplicationCommands.Copy;
			PasteCommand = ApplicationCommands.Paste;
		}
	}
}
