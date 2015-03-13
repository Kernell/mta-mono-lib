using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerTargetEventArgs : System.EventArgs
	{
		public PlayerTargetEventArgs( Element targettedElement )
		{
			this.Target = targettedElement;
		}

		public Element Target;
	}
}
