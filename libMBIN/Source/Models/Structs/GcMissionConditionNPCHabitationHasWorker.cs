﻿namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7C5DB65E2CF0F90)]
    public class GcMissionConditionNPCHabitationHasWorker : NMSTemplate
    {
        public GcNPCHabitationType WorkerType;
		public enum WorkerInCurrentBaseEnum { DontCare, Yes, No }
		public WorkerInCurrentBaseEnum WorkerInCurrentBase;
    }
}
