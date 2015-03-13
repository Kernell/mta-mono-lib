using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class ColShapeEventArgs : System.EventArgs
	{
		public ColShapeEventArgs( Element hitElement, bool matchingDimension )
		{
			this.HitElement			= hitElement;
			this.MatchingDimension	= matchingDimension;
		}

		/// <summary>
		/// the element that entered or leaved the colshape.
		/// </summary>
		public Element HitElement;

		/// <summary>
		/// a boolean referring to whether the hit collision shape was in the same dimension as the element.
		/// </summary>
		public bool MatchingDimension;
	}
}
