﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9DD8603DDE3E0BDF)]
    public class GcPhotoBuilding : NMSTemplate
    {
		public enum PhotoBuildingTypeEnum { Shelter, Abandoned, Shop, Outpost, RadioTower, Observatory, Depot, Monolith, Factory, Portal, Ruin, MissionTower }
		public PhotoBuildingTypeEnum PhotoBuildingType;
    }
}
