﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7ED9817F76276B01)]
    public class GcCreatureSizeClasses : NMSTemplate
    {
		public enum CreatureSizeClassEnum { Small, Medium, Large, Huge }
		public CreatureSizeClassEnum CreatureSizeClass;
    }
}
