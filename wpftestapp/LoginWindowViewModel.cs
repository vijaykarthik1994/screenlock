using GalaSoft.MvvmLight.Command;
using System;

namespace wpftestapp
{
	/// <summary>
	/// LoginWindowViewModel class details .
	/// </summary>
	public class LoginWindowViewModel
	{

		#region Properties
		/// <summary>
		/// Gets or sets the login command.
		/// </summary>
		/// <value>
		/// The login command.
		/// </value>
		public RelayCommand LoginCommand { get; set; }

		/// <summary>
		/// Gets or sets the logged in.
		/// </summary>
		/// <value>
		/// The logged in.
		/// </value>
		public Action LoggedIn { get; set; }

		#endregion

		#region Constructor
		public LoginWindowViewModel(Action toExecute)
		{
			this.LoggedIn = toExecute;
			this.LoginCommand = new RelayCommand(this.LoginExecute);
		}
		#endregion

		#region Methods
		private void LoginExecute()
		{
			this.LoggedIn();
		}
		#endregion
	}
}
