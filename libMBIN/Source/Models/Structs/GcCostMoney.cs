﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0CFD91697CCC3D372)]
    public class GcCostMoney : NMSTemplate
    {
        public int Cost;
		public enum CostCurrencyEnum { Units, Nanites, Specials }
		public CostCurrencyEnum CostCurrency;
    }
}
