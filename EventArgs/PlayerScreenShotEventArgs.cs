using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerScreenShotEventArgs : System.EventArgs
	{
		public PlayerScreenShotEventArgs( Resource resource, string status, string imageData, int timestamp, string tag )
		{
			this.Resource	= resource;
			this.Status		= status;
			this.ImageData	= imageData;
			this.Timestamp	= timestamp;
			this.Tag		= tag;
		}

		public Resource Resource;
		public string Status;
		public string ImageData;
		public int Timestamp;
		public string Tag;
	}
}
