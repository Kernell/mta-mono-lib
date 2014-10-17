using System;
using System.Collections.Generic;
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

		#region Constructors

		public Element( UInt32 userdata )
		{
			this.userdata = userdata;
		}
		
		public Element( string type, string ID )
			: this( Native.Element.Create( type, ID ) )
		{

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

		public static Object GetByID( string elementID, int index = 0 )
		{
			return Element.FindOrCreate( Native.Element.GetByID( elementID, index ) );
		}

		public static Object GetByIndex( string type, int index )
		{
			return Element.FindOrCreate( Native.Element.GetByIndex( type, index ) );
		}

		#endregion
	}
}
