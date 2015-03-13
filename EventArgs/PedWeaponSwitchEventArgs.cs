using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PedWeaponSwitchEventArgs : System.EventArgs
	{
		public PedWeaponSwitchEventArgs( int previousWeaponID, int currentWeaponID )
		{
			this.PreviousWeaponID	= previousWeaponID;
			this.CurrentWeaponID	= currentWeaponID;
		}

		public int PreviousWeaponID;
		public int CurrentWeaponID;
	}
}
