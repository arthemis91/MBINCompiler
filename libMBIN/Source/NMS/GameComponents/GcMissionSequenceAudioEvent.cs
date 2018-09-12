﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7C5672340F34A3E7)]
    public class GcMissionSequenceAudioEvent : NMSTemplate      // size: 0x84
    {
        public GcAudioWwiseEvents AudioEvent;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}