using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class ElementDataChangeEventArgs : System.EventArgs
	{
		public ElementDataChangeEventArgs( string name, dynamic oldValue, Player client )
		{
			this.Name		= name;
			this.OldValue	= oldValue;
			this.Client		= client;
		}

		public string Name;
		public dynamic OldValue;
		public Player Client;
	}
}
