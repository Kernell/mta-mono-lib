using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerChangeNickEventArgs : CancelEventArgs
	{
		public PlayerChangeNickEventArgs( string oldNick, string newNick )
		{
			this.Old = oldNick;
			this.New = newNick;
		}

		public string Old
		{
			private set;
			get;
		}

		public string New
		{
			private set;
			get;
		}
	}
}
