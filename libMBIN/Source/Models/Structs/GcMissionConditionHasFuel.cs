﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D823CB345FE050A8)]
    public class GcMissionConditionHasFuel : NMSTemplate
    {
        public GcStatsTypes TargetStat;
        public int Amount;
    }
}
