﻿namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceFreighterDefend : NMSTemplate      // size: 0x100
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
