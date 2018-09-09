﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F28FCA1E3D439CD9)]
    public class GcCreatureGroupDescription : NMSTemplate       // size: 0x20
    {
        [NMS(Size = 0x10)]
        public string Group;
        public int MinGroupSize;                // 1
        public int MaxGroupSize;                // 3
        public float GroupsPerSquareKm;         // 41200000h
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
