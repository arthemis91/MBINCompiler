﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x234DE601620B66D9)]
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Size = 6)]
        public GcPlayerHazardData[] Table;
    }
}
