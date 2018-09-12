﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x545A5722C6D6E44E)]
    public class TkProceduralTextureList : NMSTemplate      //size: 0x200
    {
        [NMS(Size = 0x8)]
        public TkProceduralTextureLayer[] Layers;
    }
}