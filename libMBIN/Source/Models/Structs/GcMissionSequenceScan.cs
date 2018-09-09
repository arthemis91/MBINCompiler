﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x256D94AAEF4CD46D)]
    public class GcMissionSequenceScan : NMSTemplate        // size: 0x108
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public float WaitTime;
        /* 0x084 */ public bool BlockTimedScans;
        [NMS(Size = 0x80)]
        /* 0x085 */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x105 */ public byte[] EndPadding;
    }
}
