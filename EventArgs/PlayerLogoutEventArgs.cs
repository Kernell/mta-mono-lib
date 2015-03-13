using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerLogoutEventArgs : System.EventArgs
	{
		public PlayerLogoutEventArgs( Account previousAccount, Account currentAccount )
		{
			this.PreviousAccount	= previousAccount;
			this.CurrentAccount		= currentAccount;
		}

		public Account PreviousAccount;
		public Account CurrentAccount;
	}
}
