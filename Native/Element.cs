using System;
using System.Runtime.CompilerServices;

namespace MultiTheftAuto.Native
{
    public class Element
    {
		// Element create/destroy

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Element Create( string type, string ID );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool Destroy( Element element );

		// Element get funcs

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Element Clone( Element element, Vector3 position = null, bool cloneChildren = false );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Element GetByID( string elementID, int index = 0 );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Element GetByIndex( string type, int index );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Element GetChild( Element parent, int index );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool GetChildrenCount( Element parent );

//		[MethodImpl( MethodImplOptions.InternalCall )]
//		public static extern Object GetData( Element element, string key, bool inherit = true );

//		[MethodImpl( MethodImplOptions.InternalCall )]
//		public static extern Array GetAllData( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Element GetParent( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Vector3 GetPosition( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Vector3 GetRotation( Element element, string order = "default" );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Vector3 GetVelocity( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetInterior( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsWithinColShape( Element element, ColShape colshape );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsWithinMarker( Element element, Marker marker );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetDimension( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern string GetZoneName( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsAttached( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Element GetAttachedTo( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern ColShape GetColShape( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetAlpha( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsDoubleSided( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern float GetHealth( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetModel( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool IsInWater( Element element );

//		[MethodImpl( MethodImplOptions.InternalCall )]
//		public static extern bool GetElementAttachedOffsets( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Element GetSyncer( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool GetCollisionsEnabled( Element element );

        [MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool IsFrozen( Element element );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern Element GetLowLODElement( Element element );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool IsElementLowLOD( Element element );

		// Element set funcs

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool ClearElementVisibleTo( Element element );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetID( Element element, string ID );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetData( Element element, string key, string value, bool sync = true );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool RemoveData( Element element, string key );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetParent( Element element, Element parent );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetPosition( Element element, Vector3 position, bool warp = true );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetRotation( Element element, Vector3 rotation, string order = "default", bool pedRotation = false );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetVelocity( Element element, Vector3 velocity );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetVisibleTo( Element element, Element target, bool visible );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetInterior( Element element, int interior, Vector3 position = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetDimension( Element element, int dimension );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool Attach( Element element, Element target, Vector3 offsetPosition = null, Vector3 offsetRotation = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool Detach( Element element, Element target = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetAlpha( Element element, int alpha );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetDoubleSided( Element element, bool doubleSided );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetHealth( Element element, float health );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetModel( Element element, int model );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetAttachedOffsets( Element element, Vector3 offsetPosition = null, Vector3 offsetRotation = null );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetSyncer( Element element, Element player );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetCollisionsEnabled( Element element, bool enabled );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool SetFrozen( Element element, bool frozen );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern bool setLowLODElement( Element element, Element lowLod );
    }
}
