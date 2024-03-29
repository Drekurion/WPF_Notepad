﻿using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Input;
using WPF_Notepad.Models;

namespace WPF_Notepad.ViewModels
{
	public class FileViewModel
	{
		public DocumentModel Document { get; private set; }

		//Toolbar commands
		public ICommand NewCommand { get; }
		public ICommand SaveCommand { get; }
		public ICommand SaveAsCommand { get; }
		public ICommand OpenCommand { get; }

		public ICommand ExitCommand { get; }

		public FileViewModel(DocumentModel document)
		{
			Document = document;
			NewCommand = new RelayCommand(NewFile);
			SaveCommand = new RelayCommand(SaveFile);
			SaveAsCommand = new RelayCommand(SaveFileAs);
			OpenCommand = new RelayCommand(OpenFile);
			ExitCommand = new RelayCommand(Exit);
		}

		public void NewFile()
		{
			Document.FileName = string.Empty;
			Document.FilePath = string.Empty;
			Document.Text = string.Empty;
		}

		private void SaveFile()
		{
			if (PathToFileExists()) File.WriteAllText(Document.FilePath, Document.Text);
			else SaveFileAs();
		}

		private void SaveFileAs()
		{
			var saveFileDialog = new SaveFileDialog
			{
				Filter = "Text File (*.txt)|*.txt"
			};
			if (saveFileDialog.ShowDialog() == true)
			{
				DockFile(saveFileDialog);
				File.WriteAllText(saveFileDialog.FileName, Document.Text);
			}
		}

		private void OpenFile()
		{
			var openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == true)
			{
				DockFile(openFileDialog);
				Document.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		private void Exit()
		{
			Application.Current.Shutdown();
		}

		private void DockFile(FileDialog dialog)
		{
			Document.FilePath = dialog.FileName;
			Document.FileName = dialog.SafeFileName;
		}

		private bool PathToFileExists()
		{
			if (string.IsNullOrEmpty(Document.FilePath)) return false;
			return true;
		}
	}
}
