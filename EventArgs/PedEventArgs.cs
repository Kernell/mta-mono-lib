using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PedEventArgs : System.EventArgs
	{
		public PedEventArgs( Ped ped )
		{
			this.Ped = ped;
		}

		public Ped Ped;
	}
}
