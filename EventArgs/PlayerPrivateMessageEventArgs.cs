using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerPrivateMessageEventArgs : PlayerCancelEventArgs
	{
		public PlayerPrivateMessageEventArgs( string message, Player recipient )
			: base( recipient )
		{
			this.Message = message;
		}

		public string Message;
	}
}
