using System;
using System.Runtime.CompilerServices;

namespace MultiTheftAuto.Native
{
    public static class Event
    {
        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool Add( string name );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool AddHandler( string eventName, Object attachedTo, Delegate handlerFunction, bool getPropagated = true, string priority = "normal" );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool RemoveHandler( string eventName, Object attachedTo, Delegate handlerFunction );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern Array GetHandlers( string eventName, Object attachedTo );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool Trigger( string eventName, Object baseElement, params Object[] arguments );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool TriggerClient( Object sendTo, string name, Object sourceElement, params Object[] arguments );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool Cancel( bool cancel = true, string reason = "" );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern string GetCancelReason();

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern bool WasCancelled();

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int TriggerLatentClient( Object sendTo, string name, int bandwidth, bool persist, Object theElement, params Object[] arguments );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetLatentHandles( Object player );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int GetLatentStatus( Object player, int handle );

        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern int CancelLatent( Object player, int handle );
    }
}
