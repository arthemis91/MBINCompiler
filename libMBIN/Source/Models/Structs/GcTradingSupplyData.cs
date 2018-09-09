﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x47465FFF4364C345)]
    public class GcTradingSupplyData : NMSTemplate      // size: 0x28
    {
        public ulong GalacticAddress;
        public float Supply;
        public float Demand;
        [NMS(Size = 0x10)]
        public string Product;
        public ulong Timestamp;
    }
}
