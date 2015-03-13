using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerChatEventArgs : System.EventArgs
	{
		public PlayerChatEventArgs( string message, int messageType )
		{
			this.Message	= message;
			this.Type		= messageType;
		}

		public string Message;
		public int Type;
	}
}
