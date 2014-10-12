﻿using System;
using System.Runtime.CompilerServices;

namespace MultiTheftAuto.Native
{
	public class Player : Ped
	{
		// Player get functions
		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern int GetCount();

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Array GetAlivePlayers();

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Array GetDeadPlayers();
		
		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern int GetAmmoInClip( UInt32 ped, int weaponSlot = 0 );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern int GetTotalAmmo( UInt32 ped, int weaponSlot = 0 );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetWeaponAmmo( UInt32 player, int weapon, int totalAmmo, int ammoInClip = 0 );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern UInt32 GetFromName( string name );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern int GetMoney( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern int GetPing( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern UInt32 GetRandom( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool IsMuted( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern UInt32 GetTeam( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern int GetWantedLevel( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern int GetIdleTime( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool IsMapForced( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetNametagText( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Color GetNametagColor( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool IsNametagShowing( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetSerial( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetUserName( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetBlurLevel( Player player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetName( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetIP( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern UInt32 GetAccount( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern string GetVersion( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Object GetACInfo( UInt32 player );

		// Player set functions
		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetMoney( UInt32 player, int money );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool GiveMoney( UInt32 player, int money );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool TakeMoney( UInt32 player, int money );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool Spawn( UInt32 player, Vector3 position, int rotation = 0, int skinID = 0, int interior = 0, int dimension = 0, Team theTeam = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool ShowHudComponent( UInt32 player, string component, bool show );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetWantedLevel( UInt32 player, int level );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool ForceMap( UInt32 player, bool forcedOn );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetNametagText( UInt32 player, string text );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetNametagColor( UInt32 player, Color color );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetNametagShowing( UInt32 player, bool showed );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetMuted( UInt32 player, bool muted );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetBlurLevel( UInt32 player, int level );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool Redirect( UInt32 player, string serverIP, int serverPort, string serverPassword = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetName( UInt32 player, string name );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool DetonateSatchels( UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool TakePlayerScreenShot( UInt32 player, int width, int height, string tag = "", int quality = 30, int maxBandwith = 5000 );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetPlayerTeam( UInt32 player, UInt32 team );
	}
}
