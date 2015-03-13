using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class ElementModelChangeEventArgs : System.EventArgs
	{
		public ElementModelChangeEventArgs( int oldModel, int newModel )
		{
			this.OldModel = oldModel;
			this.NewModel = newModel;
		}

		public int OldModel;
		public int NewModel;
	}
}
