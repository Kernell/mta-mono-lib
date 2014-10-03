using System;
using System.Runtime.CompilerServices;

namespace MultiTheftAuto.Native
{
    public static class Config
    {
        [MethodImpl( MethodImplOptions.InternalCall )]
        public static extern string Get( string key );
    }
}
