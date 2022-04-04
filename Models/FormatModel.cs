using System.Windows;
using System.Windows.Media;

namespace WPF_Notepad.Models
{
	public class FormatModel : ObservableObject
	{
		private FontStyle style;
		public FontStyle Style
		{
			get => style;
			set => OnPropertyChanged(ref style, value);
		}

		private FontWeight weight;
		public FontWeight Weight
		{
			get => weight;
			set => OnPropertyChanged(ref weight, value);
		}

		private FontFamily family = new FontFamily("Consolas");
		public FontFamily Family
		{
			get => family;
			set => OnPropertyChanged(ref family, value);
		}

		private TextWrapping wrap;
		public TextWrapping Wrap
		{
			get => wrap;
			set
			{
				OnPropertyChanged(ref wrap, value);
				IsWrapped = value == TextWrapping.Wrap ? true : false;
			}
		}

		private bool isWrapped;
		public bool IsWrapped
		{
			get => isWrapped;
			set => OnPropertyChanged(ref isWrapped, value);
		}

		private double size = 11;
		public double Size
		{
			get => size;
			set => OnPropertyChanged(ref size, value);
		}
	}
}
