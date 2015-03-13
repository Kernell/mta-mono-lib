using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PedWastedEventArgs : System.EventArgs
	{
		public PedWastedEventArgs( int totalAmmo, Element killer, int killerWeapon, int bodypart, bool stealth )
		{
			this.TotalAmmo		= totalAmmo;
			this.Killer			= killer;
			this.KillerWeapon	= killerWeapon;
			this.Bodypart		= bodypart;
			this.Stealth		= stealth;
		}

		public int TotalAmmo;
		public Element Killer;
		public int KillerWeapon;
		public int Bodypart;
		public bool Stealth;
	}
}
