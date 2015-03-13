using System;
using System.Collections.Generic;
using MultiTheftAuto.EventArgs;
using MultiTheftAuto.Pools;
using MultiTheftAuto.Utils;

namespace MultiTheftAuto
{
	public class Element : IdentifiedPool<Element>, IIdentifyable
	{
		#region Properties

		public UInt32 userdata
		{
			get;
			private set;
		}

		#endregion

		#region Static properties

		public static Element Root
		{
			get
			{
				return Element.FindOrCreate( Native.Element.GetRootElement() );
			}
		}

		#endregion

		#region Constructors
		
		public Element( string type, string ID )
			: this( Native.Element.Create( type, ID ) )
		{

		}

		public Element( UInt32 userdata )
		{
			this.userdata = userdata;
		}

		#endregion

		#region Methods

		#region Set

		public bool Destroy()
		{
			return Native.Element.Destroy( this.userdata );
		}

		public Element Clone( Vector3 position = null, bool cloneChildren = false )
		{
			return Element.FindOrCreate( Native.Element.Clone( this.userdata, position, cloneChildren ) );
		}

		public bool ClearElementVisibleTo()
		{
			return Native.Element.ClearElementVisibleTo( this.userdata );
		}

		public bool SetID( string id )
		{
			return Native.Element.SetID( this.userdata, id );
		}

		public bool SetData( string key, string value, bool sync = true )
		{
			return Native.Element.SetData( this.userdata, key, value, sync );
		}

		public bool RemoveData( string key )
		{
			return Native.Element.RemoveData( this.userdata, key );
		}

		public bool SetParent( UInt32 parent )
		{
			return Native.Element.SetParent( this.userdata, parent );
		}

		public bool SetPosition( Vector3 position, bool warp = true )
		{
			return Native.Element.SetPosition( this.userdata, position, warp );
		}

		public bool SetRotation( Vector3 rotation, string order = "default", bool pedRotation = false )
		{
			return Native.Element.SetRotation( this.userdata, rotation, order, pedRotation );
		}

		public bool SetVelocity( Vector3 velocity )
		{
			return Native.Element.SetVelocity( this.userdata, velocity );
		}

		public bool SetVisibleTo( Element target, bool visible )
		{
			return Native.Element.SetVisibleTo( this.userdata, target.GetUserData(), visible );
		}

		public bool SetInterior( int interior, Vector3 position = null )
		{
			return Native.Element.SetInterior( this.userdata, interior, position );
		}

		public bool SetDimension( int dimension )
		{
			return Native.Element.SetDimension( this.userdata, dimension );
		}

		public bool Attach( Element target, Vector3 offsetPosition = null, Vector3 offsetRotation = null )
		{
			return Native.Element.Attach( this.userdata, target.GetUserData(), offsetPosition, offsetRotation );
		}

		public bool Detach( Element target )
		{
			return Native.Element.Detach( this.userdata, target.GetUserData() );
		}

		public bool SetAlpha( int alpha )
		{
			return Native.Element.SetAlpha( this.userdata, alpha );
		}

		public bool SetDoubleSided( bool doublesided )
		{
			return Native.Element.SetDoubleSided( this.userdata, doublesided );
		}

		public bool SetHealth( float health )
		{
			return Native.Element.SetHealth( this.userdata, health );
		}

		public bool SetModel( int model )
		{
			return Native.Element.SetModel( this.userdata, model );
		}

		public bool SetAttachedOffsets( Vector3 offsetPosition = null, Vector3 offsetRotation = null )
		{
			return Native.Element.SetAttachedOffsets( this.userdata, offsetPosition, offsetRotation );
		}

		public bool SetSyncer( Player player )
		{
			return Native.Element.SetSyncer( this.userdata, player.GetUserData() );
		}

		public bool SetCollisionsEnabled( bool enabled )
		{
			return Native.Element.SetCollisionsEnabled( this.userdata, enabled );
		}

		public bool SetFrozen( bool frozen )
		{
			return Native.Element.SetFrozen( this.userdata, frozen );
		}

		public bool SetLowLODElement( Element element )
		{
			return Native.Element.SetLowLODElement( this.userdata, element.GetUserData() );
		}

		#endregion

		#region Get

		public string GetID()
		{
			return Native.Element.GetID( this.userdata );
		}

		public string GetData( string key, bool inherit = true )
		{
			return Native.Element.GetData( this.userdata, key, inherit );
		}

		public new string GetType()
		{
			return Native.Element.GetType( this.userdata );
		}

		public Object GetChild( UInt32 parent, int index )
		{
			return Element.FindOrCreate( Native.Element.GetChild( this.userdata, index ) );
		}

		public int GetChildrenCount()
		{
			return Native.Element.GetChildrenCount( this.userdata );
		}

		public Object GetParent()
		{
			return Element.FindOrCreate( Native.Element.GetParent( this.userdata ) );
		}

		public Vector3 GetPosition()
		{
			return Native.Element.GetPosition( this.userdata );
		}

		public Vector3 GetRotation( string order = "default" )
		{
			return Native.Element.GetRotation( this.userdata, order );
		}

		public Vector3 GetVelocity()
		{
			return Native.Element.GetVelocity( this.userdata );
		}

		public int GetInterior()
		{
			return Native.Element.GetInterior( this.userdata );
		}

		public int GetDimension()
		{
			return Native.Element.GetDimension( this.userdata );
		}

		public string GetZoneName()
		{
			return Native.Element.GetZoneName( this.userdata );
		}

		public Object GetAttachedTo()
		{
			return Element.FindOrCreate( Native.Element.GetAttachedTo( this.userdata ) );
		}

		public Object GetColShape()
		{
			return Element.FindOrCreate( Native.Element.GetColShape( this.userdata ) );
		}

		public int GetAlpha()
		{
			return Native.Element.GetAlpha( this.userdata );
		}

		public float GetHealth()
		{
			return Native.Element.GetHealth( this.userdata );
		}

		public int GetModel()
		{
			return Native.Element.GetModel( this.userdata );
		}

		public Player GetSyncer()
		{
			return Element.FindOrCreate( Native.Element.GetSyncer( this.userdata ) ) as Player;
		}

		public bool GetCollisionsEnabled()
		{
			return Native.Element.GetCollisionsEnabled( this.userdata );
		}

		public Object GetLowLODElement()
		{
			return Element.FindOrCreate( Native.Element.GetLowLODElement( this.userdata ) );
		}

		#endregion

		#region Is

		public bool IsValid()
		{
			return Native.Element.IsElement( this.userdata );
		}

		public bool IsWithinColShape( ColShape colshape )
		{
			return Native.Element.IsWithinColShape( this.userdata, colshape.GetUserData() );
		}

		public bool IsWithinMarker( Marker marker )
		{
			return Native.Element.IsWithinMarker( this.userdata, marker.GetUserData() );
		}

		public bool IsAttached()
		{
			return Native.Element.IsAttached( this.userdata );
		}

		public bool IsDoubleSided()
		{
			return Native.Element.IsDoubleSided( this.userdata );
		}

		public bool IsInWater()
		{
			return Native.Element.IsInWater( this.userdata );
		}

		public bool IsFrozen()
		{
			return Native.Element.IsFrozen( this.userdata );
		}

		public bool IsElementLowLOD()
		{
			return Native.Element.IsElementLowLOD( this.userdata );
		}

		#endregion

		public override int GetHashCode()
		{
			return (int)this.GetHashCode();
		}

		public uint GetUserData()
		{
			return this.userdata;
		}

		public override string ToString()
		{
			return string.Format( "[{0}: 0x{1}]", this.GetType(), this.userdata.ToString( "X" ) );
		}

		#endregion

		#region Static methods

		public static T[] GetByType<T>( string elementType ) where T : class
		{
			UInt32[] userdataArray = Native.Element.GetByType( elementType );

			T[] elements = new T[ userdataArray.Length ];

			for( uint i = 0; i < userdataArray.Length; i++ )
			{
				elements.SetValue( Element.FindOrCreate( userdataArray[ i ] ) as T, i );
			}
			
			return elements;
		}

		public static Object GetByID( string elementID, int index = 0 )
		{
			return Element.FindOrCreate( Native.Element.GetByID( elementID, index ) );
		}

		public static Object GetByIndex( string type, int index )
		{
			return Element.FindOrCreate( Native.Element.GetByIndex( type, index ) );
		}

		#endregion

		#region Events

		#region Client events

		/// <summary>
		/// This event is triggered when a player types a message into his console. It is also triggered when entering '/' commands via the chatbox.
		/// </summary>
		public event EventHandler<ConsoleEventArgs> Console;

		#endregion

		#region Colshape events

		/// <summary>
		/// This event is triggered when an physical element hits a colshape.
		/// NOTE: The hit won't be detected if the element that entered the colshape is a colshape.
		/// </summary>
		public event EventHandler<ColShapeEventArgs> ColShapeHit;

		/// <summary>
		/// This event is triggered when a player or a vehicle leaves a collision shape.
		/// </summary>
		public event EventHandler<ColShapeEventArgs> ColShapeLeave;

		#endregion

		#region Element events

		/// <summary>
		/// This event is triggered when an element gets destroyed by destroyElement or when the creator resource is stopping.
		/// It is also triggered when a parent element of this element is destroyed.
		/// </summary>
		public event EventHandler ElementDestroy;

		/// <summary>
		/// This event is triggered when an elementdata entry for an element changes.
		/// A client can perform this change on the element or it can be done using setElementData.
		/// </summary>
		public event EventHandler<ElementDataChangeEventArgs> ElementDataChange;

		/// <summary>
		/// This event is triggered when an player or vehicle element collides with a colshape.
		/// </summary>
		public event EventHandler<ElementColShapeEventArgs> ElementColShapeHit;

		/// <summary>
		/// This event is triggered when an player or vehicle element leaves the area of a colshape.
		/// </summary>
		public event EventHandler<ElementColShapeEventArgs> ElementColShapeLeave;

		/// <summary>
		/// This event is triggered when an element is clicked on by the client.
		/// These events can only trigger when the client has its cursor enabled.
		/// It triggers for all three mousebuttons in both their up and down states.
		/// </summary>
		public event EventHandler<ElementClickedEventArgs> ElementClicked;

		/// <summary>
		/// This event is triggered when an element becomes synced by a player.
		/// </summary>
		public event EventHandler<PlayerEventArgs> ElementStartSync;

		/// <summary>
		/// This event is triggered when an element is no longer synced by a player.
		/// </summary>
		public event EventHandler<PlayerEventArgs> ElementStopSync;

		/// <summary>
		/// This event is triggered when the model of an element is changed using setElementModel.
		/// </summary>
		public event EventHandler<ElementModelChangeEventArgs> ElementModelChange;

		#endregion

		#region Marker events

		/// <summary>
		/// This event is triggered when an element enters a marker.
		/// </summary>
		public event EventHandler<MarkerEventArgs> MarkerHit;

		/// <summary>
		/// This event is triggered when an element leaves the area of a marker.
		/// </summary>
		public event EventHandler<MarkerEventArgs> MarkerLeave;

		#endregion

		#region Pickup events

		/// <summary>
		/// This event is triggered when a pickup is spawned or respawned.
		/// </summary>
		public event EventHandler PickupSpawn;

		/// <summary>
		/// This event is triggered when a player hits a pickup.
		/// </summary>
		public event EventHandler<PlayerCancelEventArgs> PickupHit;

		/// <summary>
		/// This event is triggered when a player stands on a pickup while not in a vehicle.
		/// </summary>
		public event EventHandler<PlayerCancelEventArgs> PickupUse;

		#endregion

		#region Player events

		/// <summary>
		/// This event is triggered when a player added a ban (like onBan).
		/// </summary>
		public event EventHandler<PlayerBanEventArgs> PlayerBan;

		/// <summary>
		/// This event is triggered when a player chats inside the chat box.
		/// </summary>
		public event EventHandler<PlayerChatEventArgs> PlayerChat;

		/// <summary>
		/// This event is triggered when a player sends a private message with msg command.
		/// </summary>
		public event EventHandler<PlayerPrivateMessageEventArgs> PlayerPrivateMessage;

		/// <summary>
		/// This event is triggered when a player attempts to connect to the server.
		/// </summary>
		public event EventHandler<PlayerConnectEventArgs> PlayerConnect;

		/// <summary>
		/// This event is triggered when a player changes his nickname.
		/// </summary>
		public event EventHandler<PlayerChangeNickEventArgs> PlayerChangeNick;

		/// <summary>
		/// This event is triggered when a player logs into their account in-game.
		/// </summary>
		public event EventHandler<PlayerLoginEventArgs> PlayerLogin;

		/// <summary>
		/// This event is triggered when a user logs out of their account in-game.
		/// </summary>
		public event EventHandler<PlayerLogoutEventArgs> PlayerLogout;

		/// <summary>
		/// This event is triggered when a player is damaged, in any way.
		/// </summary>
		public event EventHandler<PlayerDamageEvetArgs> PlayerDamage;

		/// <summary>
		/// This event is triggered when a player joins the server.
		/// </summary>
		public event EventHandler PlayerJoin;

		/// <summary>
		/// This event is triggered when a player disconnects from the server.
		/// </summary>
		public event EventHandler<PlayerQuitEventArgs> PlayerQuit;

		/// <summary>
		/// This event is called when a player spawns.
		/// </summary>
		public event EventHandler<PlayerSpawnEventArgs> PlayerSpawn;

		/// <summary>
		/// This event is triggered when a player is killed or dies.
		/// </summary>
		public event EventHandler<PedWastedEventArgs> PlayerWasted;

		/// <summary>
		/// This event is triggered when a player targets an element with his crosshair while aiming, or simply facing it while standing close.
		/// It's triggered again when the player no longer targets anything.
		/// </summary>
		public event EventHandler<PlayerTargetEventArgs> PlayerTarget;

		/// <summary>
		/// This event is triggered when a player enters a vehicle.
		/// </summary>
		public event EventHandler<PlayerVehicleEnterEventArgs> PlayerVehicleEnter;

		/// <summary>
		/// This event is triggered when a player leaves a vehicle, for whatever reason.
		/// </summary>
		public event EventHandler<PlayerVehicleEnterEventArgs> PlayerVehicleExit;

		/// <summary>
		/// This event is triggered whenever a player's equipped weapon slot changes.
		/// This means giveWeapon and takeWeapon will trigger this function if the equipped slot is forced to change.
		/// </summary>
		public event EventHandler<PedWeaponSwitchEventArgs> PlayerWeaponSwitch;

		/// <summary>
		/// This event is triggered when a player hits a marker.
		/// </summary>
		public event EventHandler<PlayerMarkerEventArgs> PlayerMarkerHit;

		/// <summary>
		/// This event is triggered when a player leaves the area of a marker.
		/// </summary>
		public event EventHandler<PlayerMarkerEventArgs> PlayerMarkerLeave;

		/// <summary>
		/// This event is triggered when a player hits a pickup.
		/// </summary>
		public event EventHandler<PlayerPickupHitEventArgs> PlayerPickupHit;

		/// <summary>
		/// This event is triggered when a player is standing on a pickup while not being in a vehicle.
		/// </summary>
		public event EventHandler<PlayerPickupUseEventArgs> PlayerPickupUse;

		/// <summary>
		/// This event is triggered when a player clicks using the mouse cursor.
		/// </summary>
		public event EventHandler<PlayerClickEventArgs> PlayerClick;

		/// <summary>
		/// This event is triggered when a player stands on a different element than before.
		/// </summary>
		public event EventHandler<PlayerContactEventArgs> PlayerContact;

		/// <summary>
		/// This event is triggered when a player stealth kills another player.
		/// </summary>
		public event EventHandler<PedCancelEventArgs> PlayerStealthKill;

		/// <summary>
		/// This event is triggered when a player has been muted by setPlayerMuted.
		/// </summary>
		public event EventHandler<CancelEventArgs> PlayerMute;

		/// <summary>
		/// This event is triggered when a player has been unmuted by setPlayerMuted.
		/// </summary>
		public event EventHandler<CancelEventArgs> PlayerUnmute;

		/// <summary>
		/// This event is triggered when a player issues a command.
		/// </summary>
		public event EventHandler<PlayerCommandEventArgs> PlayerCommand;

		/// <summary>
		/// This event is triggered when a player has modified certain files.
		/// </summary>
		public event EventHandler<PlayerModInfoEventArgs> PlayerModInfo;

		/// <summary>
		/// This event is triggered when a player starts talking through voice chat.
		/// </summary>
		public event EventHandler<CancelEventArgs> PlayerVoiceStart;

		/// <summary>
		/// This event is triggered when a player stops talking through voice chat
		/// </summary>
		public event EventHandler PlayerVoiceStop;

		/// <summary>
		/// This event is triggered when the screen capture requested by takePlayerScreenShot has completed.
		/// </summary>
		public event EventHandler<PlayerScreenShotEventArgs> PlayerScreenShot;

		#endregion

		#region Ped events

		/// <summary>
		/// This event is triggered when a ped is killed or dies. It is not triggered for players.
		/// </summary>
		public event EventHandler<PedWastedEventArgs> PedWasted;

		/// <summary>
		/// This event is triggered when a ped switches weapons.
		/// </summary>
		public event EventHandler<PedWeaponSwitchEventArgs> PedWeaponSwitch;

		#endregion

		#region Resource events

		/// <summary>
		/// This event is triggered when a resource is started.
		/// </summary>
		public event EventHandler<ResourceEventArgs> ResourceStart;

		/// <summary>
		/// Analogous to onResourceStart, but triggered before script files are initialised.
		/// </summary>
		public event EventHandler<ResourceEventArgs> ResourcePreStart;

		/// <summary>
		/// This event is triggered when the resource is stopped. This can occur for a number of reasons:
		/// * The stop console command was used
		/// * The restart console command was used
		/// * The resource was modified (the resource will automatically restart)
		/// * Another resource stopped it using stopResource.
		/// </summary>
		public event EventHandler<ResourceEventArgs> ResourceStop;

		#endregion

		#region Server events

		public event EventHandler<BanEventArgs> Ban;
		public event EventHandler<DebugMessageEventArgs> DebugMessage;
		public event EventHandler<SettingChangeEventArgs> SettingChange;
		public event EventHandler<AccountDataChangeEventArgs> AccountDataChange;
		public event EventHandler<UnbanEventArgs> Unban;
		public event EventHandler<ChatMessageEventArgs> ChatMessage;

		#endregion

		#region Vehicle events

		public event EventHandler<VehicleEventArgs> TrailerAttach;
		public event EventHandler<VehicleEventArgs> TrailerDetach;
		public event EventHandler<VehicleDamageEventArgs> VehicleDamage;
		public event EventHandler<VehicleRespawnEventArgs> VehicleRespawn;
		public event EventHandler<VehicleStartEnterEventArgs> VehicleStartEnter;
		public event EventHandler<VehicleStartEnterEventArgs> VehicleStartExit;
		public event EventHandler<VehicleEnterEventArgs> VehicleEnter;
		public event EventHandler<VehicleEnterEventArgs> VehicleExit;
		public event EventHandler VehicleExplode;

		#endregion

		#region Weapon events

		public event EventHandler<CancelEventArgs> WeaponFire;

		#endregion

		#endregion

		#region Event raisers

		#region Client events

		public static void OnConsole( UInt32 source, string message )
		{
			Player player = Element.FindOrCreate( source ) as Player;

			if( player.Console != null )
			{
				ConsoleEventArgs e = new ConsoleEventArgs( message );

				player.Console( player, e );
			}
		}

		#endregion

		#region Colshape events

		public static void OnColShapeHit( UInt32 source, UInt32 hit, bool matchingDimension )
		{
			Element sourceElement	= Element.FindOrCreate( source );

			if( sourceElement.ColShapeHit != null )
			{
				Element hitElement = Element.FindOrCreate( hit );

				ColShapeEventArgs e = new ColShapeEventArgs( hitElement, matchingDimension );

				sourceElement.ColShapeHit( sourceElement, e );
			}
		}

		public event EventHandler OnColShapeLeave;

		#endregion

		#region Element events

		public event EventHandler OnElementDestroy;
		public event EventHandler OnElementDataChange;
		public event EventHandler OnElementColShapeHit;
		public event EventHandler OnElementColShapeLeave;
		public event EventHandler OnElementClicked;
		public event EventHandler OnElementStartSync;
		public event EventHandler OnElementStopSync;
		public event EventHandler OnElementModelChange;

		#endregion

		#region Marker events

		public event EventHandler OnMarkerHit;
		public event EventHandler OnMarkerLeave;

		#endregion

		#region Pickup events

		public event EventHandler OnPickupSpawn;
		public event EventHandler OnPickupHit;
		public event EventHandler OnPickupUse;

		#endregion

		#region Player events

		public event EventHandler OnPlayerBan;
		public event EventHandler OnPlayerChat;
		public event EventHandler OnPlayerPrivateMessage;
		public event EventHandler OnPlayerConnect;
		public event EventHandler<PlayerChangeNickEventArgs> OnPlayerChangeNick;
		public event EventHandler OnPlayerLogin;
		public event EventHandler OnPlayerLogout;
		public event EventHandler OnPlayerDamage;
		public event EventHandler<PlayerEventArgs> OnPlayerJoin;
		public event EventHandler<PlayerQuitEventArgs> OnPlayerQuit;
		public event EventHandler OnPlayerSpawn;
		public event EventHandler OnPlayerWasted;
		public event EventHandler OnPlayerTarget;
		public event EventHandler OnPlayerVehicleEnter;
		public event EventHandler OnPlayerVehicleExit;
		public event EventHandler OnPlayerWeaponSwitch;
		public event EventHandler OnPlayerMarkerHit;
		public event EventHandler OnPlayerMarkerLeave;
		public event EventHandler OnPlayerPickupHit;
		public event EventHandler OnPlayerPickupUse;
		public event EventHandler OnPlayerClick;
		public event EventHandler OnPlayerContact;
		public event EventHandler OnPlayerStealthKill;
		public event EventHandler OnPlayerMute;
		public event EventHandler OnPlayerUnmute;
		public event EventHandler OnPlayerCommand;
		public event EventHandler<PlayerModInfoEventArgs> OnPlayerModInfo;
		public event EventHandler OnPlayerVoiceStart;
		public event EventHandler OnPlayerVoiceStop;
		public event EventHandler OnPlayerScreenShot;

		#endregion

		#region Ped events

		public event EventHandler OnPedWasted;
		public event EventHandler OnPedWeaponSwitch;

		#endregion

		#region Resource events

		public event EventHandler OnResourceStart;
		public event EventHandler OnResourcePreStart;
		public event EventHandler OnResourceStop;

		#endregion

		#region Server events

		public event EventHandler OnBan;
		public event EventHandler OnDebugMessage;
		public event EventHandler OnSettingChange;
		public event EventHandler OnAccountDataChange;
		public event EventHandler OnUnban;
		public event EventHandler OnChatMessage;

		#endregion

		#region Vehicle events

		public event EventHandler OnTrailerAttach;
		public event EventHandler OnTrailerDetach;
		public event EventHandler OnVehicleDamage;
		public event EventHandler OnVehicleRespawn;
		public event EventHandler OnVehicleStartEnter;
		public event EventHandler OnVehicleStartExit;
		public event EventHandler OnVehicleEnter;
		public event EventHandler OnVehicleExit;
		public event EventHandler OnVehicleExplode;

		#endregion

		#region Weapon events

		public event EventHandler OnWeaponFire;

		#endregion

		#endregion
	}
}
