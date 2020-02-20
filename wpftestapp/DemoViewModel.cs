using GalaSoft.MvvmLight.Messaging;
using System;
using System.Windows.Threading;

namespace wpftestapp
{
	/// <summary>
	/// DemoViewModel class details .
	/// </summary>
	public class DemoViewModel
	{
		#region PrivateMembers
		private LoginWindow lgWindow;
		private MainWindow mnWindow;
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="DemoViewModel"/> class.
		/// </summary>
		public DemoViewModel()
		{
			this.lgWindow = new LoginWindow();
			this.mnWindow = new MainWindow();
			Messenger.Default.Register<LockData>(this, (args) => this.LockScreen(args));
		}
		#endregion

		public void InitializeApplication()
		{
			Action loginExecute = () =>
			 {
				 this.lgWindow.Hide();
				 this.mnWindow.Show();
			 };
			this.lgWindow.DataContext = new LoginWindowViewModel(loginExecute);
			this.lgWindow.Show();
		}

		private void LockScreen(LockData lockInfo)
		{
			Action executeAction = () =>
{
	this.mnWindow.Hide();
	this.InitializeApplication();
};
			Dispatcher.CurrentDispatcher.Invoke(executeAction, DispatcherPriority.Normal);

		}
	}
}
