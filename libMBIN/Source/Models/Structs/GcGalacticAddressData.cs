﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0CDC0444569389B85)]
    public class GcGalacticAddressData : NMSTemplate // 0x14 bytes
    {
        public int VoxelX;

        public int VoxelY;

        public int VoxelZ;

        public int SolarSystemIndex;

        public int PlanetIndex;
    }
}
