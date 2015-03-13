using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class ElementColShapeEventArgs : System.EventArgs
	{
		public ElementColShapeEventArgs( ColShape colShape, bool matchingDimension )
		{
			this.ColShape			= colShape;
			this.MatchingDimension	= matchingDimension;
		}

		public ColShape ColShape;
		public bool MatchingDimension;
	}
}
