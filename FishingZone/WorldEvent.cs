using FishingZone.Worlds;

namespace FishingZone {
	internal static class WorldEvent {
		private static WorldZone[] _fishingZoneBonus = new WorldZone[3] { WorldZone.EuropeanDeadZone(), WorldZone.SavathunThroneWorld(), WorldZone.Nessus() };
		public static string GetFishingZoneBonus(int nbWeek) {
			WorldZone fishingWorld = _fishingZoneBonus[(nbWeek - 1).GetDiffFromNearestMultiple(_fishingZoneBonus.Length)];
			return fishingWorld.Name + " at " + fishingWorld.GetFishingZone();
		}
	}
}
