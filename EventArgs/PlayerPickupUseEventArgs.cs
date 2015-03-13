using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerPickupUseEventArgs : CancelEventArgs
	{
		public PlayerPickupUseEventArgs( Pickup pickup )
		{
			this.Pickup = pickup;
		}

		public Pickup Pickup;
	}
}
