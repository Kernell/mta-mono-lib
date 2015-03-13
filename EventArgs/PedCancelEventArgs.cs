using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PedCancelEventArgs : CancelEventArgs
	{
		public PedCancelEventArgs( Ped ped )
		{
			this.Ped = ped;
		}

		public Ped Ped;
	}
}
