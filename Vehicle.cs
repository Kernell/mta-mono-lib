using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTheftAuto
{
	public class Vehicle : Element
	{
		#region Properties

		public string Type
		{
			get
			{
				return Native.Vehicle.GetType( this.GetUserData() );
			}
		}

		#endregion

		#region Constructors

		public Vehicle( UInt32 userdata )
			: base( userdata )
		{

		}

		public Vehicle( int model, Vector3 position, Vector3 rotation, string numberplate = null, bool direction = false, int variant1 = 255, int variant2 = 255 )
			: base( Native.Vehicle.Create( model, position, rotation, numberplate, direction, variant1, variant2 ) )
		{
			
		}
		
		#endregion

		#region Methods

		#region Set

		public bool Fix()
		{
			return Native.Vehicle.Fix( this.GetUserData() );
		}

		public bool Blow( bool blow = true )
		{
			return Native.Vehicle.Blow( this.GetUserData(), blow );
		}

		public bool SetTurnVelocity( Vector3 velocity )
		{
			return Native.Vehicle.SetTurnVelocity( this.GetUserData(), velocity );
		}

		public bool SetColor( Color color1, Color color2 = null, Color color3 = null, Color color4 = null )
		{
			return Native.Vehicle.SetColor( this.GetUserData(), color1, color2, color3, color4 );
		}

		public bool SetLandingGearDown( bool state )
		{
			return Native.Vehicle.SetLandingGearDown( this.GetUserData(), state );
		}

		public bool SetLocked( bool locked )
		{
			return Native.Vehicle.SetLocked( this.GetUserData(), locked );
		}

		public bool SetDoorsUndamageable( bool state )
		{
			return Native.Vehicle.SetDoorsUndamageable( this.GetUserData(), state );
		}

		public bool SetSirensOn( bool state )
		{
			return Native.Vehicle.SetSirensOn( this.GetUserData(), state );
		}

		public bool SetTaxiLightOn( bool state )
		{
			return Native.Vehicle.SetTaxiLightOn( this.GetUserData(), state );
		}

		public bool AddUpgrade( int upgrade )
		{
			return Native.Vehicle.AddUpgrade( this.GetUserData(), upgrade );
		}

		public bool RemoveUpgrade( int upgrade )
		{
			return Native.Vehicle.RemoveUpgrade( this.GetUserData(), upgrade );
		}

		public bool SetDoorState( int door, int state )
		{
			return Native.Vehicle.SetDoorState( this.GetUserData(), door, state );
		}

		public bool SetWheelStates( int frontLeft, int rearLeft, int frontRight, int rearRight )
		{
			return Native.Vehicle.SetWheelStates( this.GetUserData(), frontLeft, rearLeft, frontRight, rearRight );
		}

		public bool SetLightState( int light, int state )
		{
			return Native.Vehicle.SetLightState( this.GetUserData(), light, state );
		}

		public bool SetPanelState( int panelID, int state )
		{
			return Native.Vehicle.SetPanelState( this.GetUserData(), panelID, state );
		}

		public bool SetIdleRespawnDelay( int timeDelay )
		{
			return Native.Vehicle.SetIdleRespawnDelay( this.GetUserData(), timeDelay );
		}

		public bool SetRespawnDelay( int timeDelay )
		{
			return Native.Vehicle.SetRespawnDelay( this.GetUserData(), timeDelay );
		}

		public bool SetRespawnPosition( Vector3 position, Vector3 rotation )
		{
			return Native.Vehicle.SetRespawnPosition( this.GetUserData(), position, rotation );
		}

		public bool ToggleRespawn( bool respawn )
		{
			return Native.Vehicle.ToggleRespawn( this.GetUserData(), respawn );
		}

		public bool ResetExplosionTime()
		{
			return Native.Vehicle.ResetExplosionTime( this.GetUserData() );
		}

		public bool ResetIdleTime()
		{
			return Native.Vehicle.ResetIdleTime( this.GetUserData() );
		}

		public bool Spawn( Vector3 position, Vector3 rotation )
		{
			return Native.Vehicle.Spawn( this.GetUserData(), position, rotation );
		}

		public bool Respawn()
		{
			return Native.Vehicle.Respawn( this.GetUserData() );
		}

		public bool SetOverrideLights( int state )
		{
			return Native.Vehicle.SetOverrideLights( this.GetUserData(), state );
		}

		public bool AttachTrailerToVehicle( Element trailer )
		{
			return Native.Vehicle.AttachTrailerToVehicle( this.GetUserData(), trailer.GetUserData() );
		}

		public bool DetachTrailerFromVehicle( Element trailer = null )
		{
			if( trailer == null )
				return Native.Vehicle.DetachTrailerFromVehicle( this.GetUserData() );

			return Native.Vehicle.DetachTrailerFromVehicle( this.GetUserData(), trailer.GetUserData() );
		}

		public bool SetEngineState( bool state )
		{
			return Native.Vehicle.SetEngineState( this.GetUserData(), state );
		}

		public bool SetDamageProof( bool state )
		{
			return Native.Vehicle.SetDamageProof( this.GetUserData(), state );
		}

		public bool SetPaintjob( int value )
		{
			return Native.Vehicle.SetPaintjob( this.GetUserData(), value );
		}

		public bool SetFuelTankExplodable( bool state )
		{
			return Native.Vehicle.SetFuelTankExplodable( this.GetUserData(), state );
		}

		public bool SetTrainDerailed( bool state )
		{
			return Native.Vehicle.SetTrainDerailed( this.GetUserData(), state );
		}

		public bool SetTrainDerailable( bool state )
		{
			return Native.Vehicle.SetTrainDerailable( this.GetUserData(), state );
		}

		public bool SetTrainDirection( bool state )
		{
			return Native.Vehicle.SetTrainDirection( this.GetUserData(), state );
		}

		public bool SetTrainSpeed( float speed )
		{
			return Native.Vehicle.SetTrainSpeed( this.GetUserData(), speed );
		}

		public bool SetHeadLightColor( Color color )
		{
			return Native.Vehicle.SetHeadLightColor( this.GetUserData(), color );
		}

		public bool SetTurretPosition( float x, float y )
		{
			return Native.Vehicle.SetTurretPosition( this.GetUserData(), x, y );
		}

		public bool SetDoorOpenRatio( int door, float ratio, int time = 0 )
		{
			return Native.Vehicle.SetDoorOpenRatio( this.GetUserData(), door, ratio, time );
		}

		public bool SetVariant( int variant1 = 255, int variant2 = 255 )
		{
			return Native.Vehicle.SetVariant( this.GetUserData(), variant1, variant2 );
		}

		public bool AddSirens( int sirenCount, int sirenType, bool flag360 = false, bool checkLos = true, bool useRandomiser = true, bool silent = false )
		{
			return Native.Vehicle.AddSirens( this.GetUserData(), sirenCount, sirenType, flag360, checkLos, useRandomiser, silent );
		}

		public bool RemoveSirens()
		{
			return Native.Vehicle.RemoveSirens( this.GetUserData() );
		}

		public bool SetSirens( int sirenPoint, Vector3 position, Color color = null, float minAlpha = 0.0f )
		{
			if( color == null )
				return Native.Vehicle.SetSirens( this.GetUserData(), sirenPoint, position, color, minAlpha );
			
			return Native.Vehicle.SetSirens( this.GetUserData(), sirenPoint, position, color, minAlpha );
		}

		public bool SetPlateText( string text )
		{
			return Native.Vehicle.SetPlateText( this.GetUserData(), text );
		}

		#endregion

		#region Get

		public Array GetSirens()
		{
			return Native.Vehicle.GetSirens( this.GetUserData() );
		}

		public Object GetSirenParams()
		{
			return Native.Vehicle.GetSirenParams( this.GetUserData() );
		}

		#endregion

		#region Is

		public bool IsTaxiLightOn()
		{
			return Native.Vehicle.IsTaxiLightOn( this.GetUserData() );
		}

		#endregion

		#endregion
	}
}
