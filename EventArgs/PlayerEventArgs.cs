using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerEventArgs : System.EventArgs
	{
		public PlayerEventArgs( Player player )
		{
			this.Player = player;
		}

		public Player Player;
	}
}
