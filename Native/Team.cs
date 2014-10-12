using System;
using System.Runtime.CompilerServices;

namespace MultiTheftAuto.Native
{
	public class Team : Element
	{
		// Team get funcs
		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern UInt32 Create( string name, Color color = new Color( 255, 255, 255 ) );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern UInt32 GetFromName( string name );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetName( UInt32 team );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Color GetColor( UInt32 team );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool GetFriendlyFire( UInt32 team );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Array GetPlayers( UInt32 team );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern int CountPlayers( UInt32 team );

		// Team set funcs
		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetName( UInt32 team, string name );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetColor( UInt32 team, Color color );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetFriendlyFire( UInt32 team, bool enabled );
	}
}
