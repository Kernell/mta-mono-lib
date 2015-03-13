using System;
using System.Runtime.CompilerServices;

namespace MultiTheftAuto
{
	public class Server
	{
		public static bool OutputChatBox( string text, Element element, Color color, bool colorCoded )
		{
			return OutputChatBox( text, element.userdata, color, colorCoded );
		}
		public static bool OutputConsole( string text, Element element )
		{
			return OutputConsole( text, element.userdata );
		}

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern uint GetMaxPlayers();

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetMaxPlayers( uint maxPlayers );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool OutputChatBox( string text, UInt32 element, Color color, bool colorCoded );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool OutputConsole( string text, UInt32 element );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetPassword( string password, bool bSave );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern ServerVersion GetVersion();

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetGameType();

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetMapName();

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetGameType( string gameType );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetMapName( string mapName );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetRuleValue( string key );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetRuleValue( string key, string value );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool RemoveRuleValue( string key );
	}
}
