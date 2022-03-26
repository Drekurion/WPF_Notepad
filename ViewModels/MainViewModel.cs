using WPF_Notepad.Models;

namespace WPF_Notepad.ViewModels
{
	public class MainViewModel
	{
		//Document that is saved, loaded and hold editor text
		private DocumentModel document;

		//Manages user input for document and format styles
		public EditorViewModel Editor { get; set; }

		//Manages saving and loading text files
		public FileViewModel File { get; set; }

		//Manage help dialog
		public HelpViewModel Help { get; set; }

		public EditViewModel Edit { get; set; }

		public MainViewModel()
		{
			document = new DocumentModel();
			Help = new HelpViewModel();
			Editor = new EditorViewModel(document);
			File = new FileViewModel(document);
			Edit = new EditViewModel();
		}
	}
}
