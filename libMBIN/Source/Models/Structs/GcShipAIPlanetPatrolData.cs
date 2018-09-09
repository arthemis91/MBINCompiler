﻿namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x38, GUID = 0x6093D382214F692D)]
    public class GcShipAIPlanetPatrolData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Squad;

        public float PlayerOffset;
        public float PlayerFalloff;
        public float PathOffset;
        public float WaypointDistance;
        public float PathSpeed;
        public float AlongPathForce;
        public float ToPathForce;
        public float BrakeForce;
        public float AlignForce;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding34;
    }
}
