﻿using System;
using System.Runtime.InteropServices;

namespace HunterPie.Core.Definitions
{
    [StructLayout(LayoutKind.Sequential, Size = 0x18)]
    public struct sHuntingHornSong : IEquatable<sHuntingHornSong>
    {
        public int Id;
        public int unkn1;
        public int NotesLength; // The amount of notes this song requires
        public int unkn2; // Always FF FF FF FF?
        public int BuffId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] Notes;

        public bool Equals(sHuntingHornSong other)
        {
            return Id == other.Id && BuffId == other.BuffId && NotesLength == other.NotesLength;
        }
    }
}
