using System.Windows;

namespace wpftestapp
{
	/// <summary>
	/// Interaction logic for DemoWinodw.xaml
	/// </summary>
	public partial class DemoWinodw : Window
	{
		public DemoWinodw()
		{
			InitializeComponent();
		}

		private void Grid_Loaded(object sender, RoutedEventArgs e)
		{
			if (this.DataContext is DemoViewModel dmvm)
			{
				dmvm.InitializeApplication();
			}
		}
	}
}
