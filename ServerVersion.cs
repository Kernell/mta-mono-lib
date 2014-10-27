using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto
{
    public class ServerVersion
    {
		public ulong Number;
		public string String;
		public string Name;
		public string BuildType;
		public ulong Netcode;
		public string OperatingSystem;
		public string BuildTag;
		public string Sortable;

		public ServerVersion( ulong number, string version, string name, string buildType, ulong netcode, string os, string tag, string sortable )
		{
			this.Number				= number;
			this.String				= version;
			this.Name				= name;
			this.BuildType			= buildType;
			this.Netcode			= netcode;
			this.OperatingSystem	= os;
			this.BuildTag			= tag;
			this.Sortable			= sortable;
		}
    }
}
