using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x28, GUID = 0x0A829A15F1ECEF45B)]
    public class GcDamageMultiplierLookup : NMSTemplate
    {

        [NMS(Size = 0x10)]
        public string Id;
        public float Default;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding14;
        public List<GcDamageMultiplier> Multipliers;
    }
}