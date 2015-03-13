using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerCommandEventArgs : CancelEventArgs
	{
		public PlayerCommandEventArgs( string command )
		{
			this.Command = command;
		}

		public string Command;
	}
}
