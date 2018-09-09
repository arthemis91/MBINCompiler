﻿namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x18, GUID = 0x6807D0364B187845)]
    public class GcPlayerSpaceshipAim : NMSTemplate
    {
        /* 0x000 */ public float AimAngleMin;
        /* 0x004 */ public float AimAngleRange;
        /* 0x008 */ public float AimDistanceAngleMin;
        /* 0x00C */ public float AimDistanceAngleRange;
        /* 0x010 */ public float AimDistanceMin;
        /* 0x014 */ public float AimDistanceRange;
    }
}
