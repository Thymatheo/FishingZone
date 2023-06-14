namespace FishingZone.Worlds {
	internal abstract class WorldZone {
		protected string _fishingZone;
		public string Name { get; set; }
		public WorldRegion[] Regions { get; set; }
		protected WorldZone(string name, int numberOfWR, string fishingZone) {
			Name = name;
			Regions = new WorldRegion[numberOfWR];
			_fishingZone = fishingZone;
		}
		protected void AddWR(string wrName) => Regions[Regions.Count(x => x != null)] = new(wrName);
		public static WorldZone Nessus() => new NessusWorld();
		public static WorldZone SavathunThroneWorld() => new SavathunThroneWorldWorld();
		public static WorldZone EuropeanDeadZone() => new EuropeanDeadZoneWorld();
		public string GetFishingZone() => Regions.First(x => x.Name == _fishingZone).Name;
	}
}
