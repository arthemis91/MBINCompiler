﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4AD6E73B9F8FF14E)]
    public class GcWikiTopicType : NMSTemplate
    {
		public enum WikiTopicTypeEnum { List, Grid }
		public WikiTopicTypeEnum WikiTopicType;
    }
}
