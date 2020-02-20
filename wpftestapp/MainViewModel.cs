using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Windows;
using System.Windows.Forms;

namespace wpftestapp
{
	/// <summary>
	/// MainViewModel class details .
	/// </summary>
	public class MainViewModel
	{
		#region Properties
		public RelayCommand SaveCommand { get; set; }
		public Window owner;
		private Timer myTimer;
		#endregion

		#region Constructor
		public MainViewModel()
		{
			this.SaveCommand = new RelayCommand(this.SaveCommandExecuted);
			myTimer = new Timer();
			myTimer.Interval = 1000 * 50;
			// Hook up the Elapsed event for the timer. 
			myTimer.Tick += OnTimedEvent;
			myTimer.Enabled = true;
		}
		#endregion

		#region Methods

		private void SaveCommandExecuted()
		{
			var wd = new Window1();
			wd.Owner = this.owner;
			wd.ShowDialog();
		}

		private static void OnTimedEvent(Object source, EventArgs args)
		{
			Messenger.Default.Send<LockData>(new LockData());
		}

		#endregion
	}
}
