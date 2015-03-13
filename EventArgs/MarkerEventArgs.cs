using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class MarkerEventArgs : System.EventArgs
	{
		public MarkerEventArgs( Element element, bool matchingDimension )
		{
			this.Element = element;
			this.MatchingDimension = matchingDimension;
		}

		public Element Element;
		public bool MatchingDimension;
	}
}
