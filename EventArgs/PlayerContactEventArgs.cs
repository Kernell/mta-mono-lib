using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerContactEventArgs : System.EventArgs
	{
		public PlayerContactEventArgs( Element previous, Element current )
		{
			this.Previous	= previous;
			this.Current	= current;
		}

		Element Previous;
		Element Current;
	}
}
