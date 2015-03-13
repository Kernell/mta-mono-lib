using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto.EventArgs
{
	public class ElementClickedEventArgs : System.EventArgs
	{
		public ElementClickedEventArgs( string mouseButton, string buttonState, Player whoClicked, float clickPosX, float clickPosY, float clickPosZ )
		{
			this.MouseButton	= mouseButton;
			this.ButtonState	= buttonState;
			this.WhoClicked		= whoClicked;
			this.ClickPosition	= new Vector3( clickPosX, clickPosY, clickPosZ );
		}

		public string MouseButton;
		public string ButtonState;
		public Player WhoClicked;
		public Vector3 ClickPosition;
	}
}
