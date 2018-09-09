﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E38558DF9FE4C519)]
    public class GcBiomeType : NMSTemplate
    {
		public enum BiomeEnum { Lush, Toxic, Scorched, Radioactive, Frozen, Barren, Dead, Weird, Red, Green, Blue, Test, All }
		public BiomeEnum Biome;
    }
}
