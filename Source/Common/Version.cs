﻿namespace Multiplayer.Common
{
    public static class MpVersion
    {
        public const string Version = "0.4.2";
        public const int Protocol = 11;

#if DEBUG
        public const bool IsDebug = true;
#else
        public const bool IsDebug = false;
#endif
    }
}
