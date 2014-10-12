using System;
using System.Runtime.CompilerServices;

namespace MultiTheftAuto.Native
{
	public class Element
    {
		// UInt32 create/destroy

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern UInt32 Create( string type, string ID );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool Destroy( UInt32 element );

		// UInt32 get funcs

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern UInt32 Clone( UInt32 element, Vector3 position = null, bool cloneChildren = false );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern UInt32 GetByID( string elementID, int index = 0 );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern UInt32 GetByIndex( string type, int index );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern UInt32 GetChild( UInt32 parent, int index );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool GetChildrenCount( UInt32 parent );

//		[MethodImpl( MethodImplOptions.InternalCall )]
//		public static extern Object GetData( UInt32 element, string key, bool inherit = true );

//		[MethodImpl( MethodImplOptions.InternalCall )]
//		public static extern Array GetAllData( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern UInt32 GetParent( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Vector3 GetPosition( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Vector3 GetRotation( UInt32 element, string order = "default" );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Vector3 GetVelocity( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetInterior( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsWithinColShape( UInt32 element, ColShape colshape );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsWithinMarker( UInt32 element, Marker marker );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetDimension( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern string GetZoneName( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsAttached( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern UInt32 GetAttachedTo( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern ColShape GetColShape( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetAlpha( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsDoubleSided( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern float GetHealth( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetModel( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsInWater( UInt32 element );

//		[MethodImpl( MethodImplOptions.InternalCall )]
//		public static extern bool GetElementAttachedOffsets( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
		public static extern UInt32 GetSyncer( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool GetCollisionsEnabled( UInt32 element );

        [MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool IsFrozen( UInt32 element );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern UInt32 GetLowLODElement( UInt32 element );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool IsElementLowLOD( UInt32 element );

		// UInt32 set funcs

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool ClearElementVisibleTo( UInt32 element );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetID( UInt32 element, string ID );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetData( UInt32 element, string key, string value, bool sync = true );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool RemoveData( UInt32 element, string key );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetParent( UInt32 element, UInt32 parent );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetPosition( UInt32 element, Vector3 position, bool warp = true );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetRotation( UInt32 element, Vector3 rotation, string order = "default", bool pedRotation = false );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetVelocity( UInt32 element, Vector3 velocity );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetVisibleTo( UInt32 element, UInt32 target, bool visible );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetInterior( UInt32 element, int interior, Vector3 position = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetDimension( UInt32 element, int dimension );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool Attach( UInt32 element, UInt32 target, Vector3 offsetPosition = null, Vector3 offsetRotation = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool Detach( UInt32 element, UInt32 target = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetAlpha( UInt32 element, int alpha );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetDoubleSided( UInt32 element, bool doubleSided );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetHealth( UInt32 element, float health );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetModel( UInt32 element, int model );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetAttachedOffsets( UInt32 element, Vector3 offsetPosition = null, Vector3 offsetRotation = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetSyncer( UInt32 element, UInt32 player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetCollisionsEnabled( UInt32 element, bool enabled );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetFrozen( UInt32 element, bool frozen );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool setLowLODElement( UInt32 element, UInt32 lowLod );
    }
}
