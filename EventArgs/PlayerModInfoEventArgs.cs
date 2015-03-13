using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerModInfoEventArgs : System.EventArgs
	{
		public PlayerModInfoEventArgs( string filename, List<PlayerModInfo> list )
		{
			this.FileName = filename;
			this.List = list;
		}

		public List<PlayerModInfo> List;

		public string FileName
		{
			private set;
			get;
		}
	}
}
