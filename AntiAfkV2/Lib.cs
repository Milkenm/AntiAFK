using System.Runtime.InteropServices;

namespace AntiAfkV2
{
	public static class Lib
	{
		[DllImport("user32.dll")]
		public static extern bool LockWorkStation();
	}
}
