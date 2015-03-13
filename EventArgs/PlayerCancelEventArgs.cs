using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerCancelEventArgs : CancelEventArgs
	{
		public PlayerCancelEventArgs( Player player )
		{
			this.Player = player;
		}

		public Player Player;
	}
}
