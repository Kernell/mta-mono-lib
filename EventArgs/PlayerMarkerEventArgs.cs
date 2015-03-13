using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class PlayerMarkerEventArgs : System.EventArgs
	{
		public PlayerMarkerEventArgs( Marker marker, bool matchingDimension )
		{
			this.Marker = marker;
			this.MatchingDimension = matchingDimension;
		}

		public Marker Marker;
		public bool MatchingDimension;
	}
}
