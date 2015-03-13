using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerBanEventArgs : System.EventArgs
	{
		public PlayerBanEventArgs( Ban banPointer, Player responsibleElement  )
		{
			this.Ban = banPointer;
			this.Responsible = responsibleElement;
		}

		public Ban Ban;
		public Player Responsible;
	}
}
