﻿namespace libMBIN.Models.Structs
{
	[NMS(Alignment = 0x8, GUID = 0x9F0B6CF8AD454951)]
    public class GcMissionConditionMissionCompleted : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */public string MissionID;
    }
}
