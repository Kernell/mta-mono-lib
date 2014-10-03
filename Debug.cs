using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace MultiTheftAuto
{
    public static class Debug
    {
        [MethodImpl( MethodImplOptions.InternalCall )]
		public static extern void Log( string message );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern void Info( string message );

		[MethodImpl( MethodImplOptions.InternalCall )]
		public static extern void Error( string message );

		public static void Log( string message, params Object[] args )
		{
			Log( String.Format( message, args ) );
		}

		public static void Info( string message, params Object[] args )
		{
			Info( String.Format( message, args ) );
		}

		public static void Error( string message, params Object[] args )
		{
			/* Не поддерживается в текущей версии Mono
			StackTrace trace = new StackTrace( true );

			StackFrame frame = trace.GetFrame( 0 );
			
			string	fileName	= frame.GetFileName();
			string	methodName	= frame.GetMethod().Name;
			int		fileLine	= frame.GetFileLineNumber();
			*/
		//	int		fileColumn	= frame.GetFileColumnNumber();
			
			Error( /*String.Format( "{0}:{1}:{2}: ", fileName, methodName, fileLine ) +*/ String.Format( message, args ) );
		}
    }
}
