using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerQuitEventArgs : System.EventArgs
	{
		public PlayerQuitEventArgs( string type, string reason, Player responsePlayer )
		{
			this.Type = type;
			this.Reason = reason;
			this.ResponsePlayer = responsePlayer;
		}

		public string Type
		{
			private set;
			get;
		}

		public string Reason
		{
			private set;
			get;
		}

		public Player ResponsePlayer
		{
			private set;
			get;
		}
	}
}
