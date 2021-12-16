using System;
using System.Collections.Generic;

namespace AntiAfkV2
{
	public class Schedule
	{
		public int Index { get; set; }
		public string Name { get; set; }
		public int ActivationHour { get; set; }
		public int ActivationMinute { get; set; }
		public List<DayOfWeek> DaysOfWeek { get; set; }
		public bool EnabledState { get; set; }
		public bool LockWindows { get; set; }
	}
}
