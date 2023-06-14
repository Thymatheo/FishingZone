namespace FishingZone {
	internal static partial class IntUtils {
		public static int GetDiffFromNearestMultiple(this int value, int multiple) =>
			value - (int.Parse(Math.Floor((double)value / (double)multiple).ToString()) * multiple);
	}
}
