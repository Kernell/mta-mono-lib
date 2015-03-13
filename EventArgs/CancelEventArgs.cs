using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class CancelEventArgs : System.EventArgs
	{
		public void Cancel( bool cancel = true, string reason ="" )
		{
			Native.Event.Cancel( cancel, reason );
		}
	}
}
