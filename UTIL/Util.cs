using System;
using System.Diagnostics;

namespace _RUDP_
{
    public static partial class Util_net
    {
        public static readonly byte[] EMPTY_BUFFER = Array.Empty<byte>();
        static readonly Stopwatch stopwatch = new();
        public static double TotalMilliseconds => stopwatch.Elapsed.TotalMilliseconds;

        //----------------------------------------------------------------------------------------------------------
        
        static Util_net()
        {
            stopwatch.Start();
            InitNet();
        }
    }
}