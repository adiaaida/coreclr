// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;

namespace System
{
    public readonly partial struct DateTime
    {
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private static extern unsafe bool ValidateSystemTime(Interop.Kernel32.SYSTEMTIME* time, bool localTime);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private static extern unsafe bool FileTimeToSystemTime(long fileTime, FullSystemTime* time);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private static extern unsafe void GetSystemTimeWithLeapSecondsHandling(FullSystemTime* time);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private static extern unsafe bool SystemTimeToFileTime(Interop.Kernel32.SYSTEMTIME* time, long* fileTime);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private static extern unsafe long GetSystemTimeAsFileTime();
    }
}
