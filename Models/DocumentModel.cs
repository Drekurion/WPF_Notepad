namespace WPF_Notepad.Models
{
	public class DocumentModel : ObservableObject
	{
		private string text;
		public string Text
		{
			get => text;
			set => OnPropertyChanged(ref text, value);
		}

		private string filePath;
		public string FilePath
		{
			get => filePath;
			set => OnPropertyChanged(ref filePath, value);
		}

		private string fileName;
		public string FileName
		{
			get => fileName;
			set => OnPropertyChanged(ref fileName, value);
		}

		public bool IsEmpty
		{
			get
			{
				if (string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath)) return true;
				return false;
			}
		}
	}
}
