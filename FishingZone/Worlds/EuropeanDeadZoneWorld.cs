namespace FishingZone.Worlds {
	internal class EuropeanDeadZoneWorld : WorldZone {
		private const string WORLD_NAME = "European Dead Zone";
		private const int NUMBER_OF_WORLD_REGION = 7;
		private const string WORLD_REGION_FIREBASE = "Firebase Hades";
		private const string WORLD_REGION_GULTCH = "The Gulch";
		private const string WORLD_REGION_OUTSKIRTS = "Outskirts";
		private const string WORLD_REGION_SLUDGE = "The Sludge";
		private const string WORLD_REGION_SUNKEN = "Sunken Isles";
		private const string WORLD_REGION_TROSTLAND = "Trostland";
		private const string WORLD_REGION_WINDING = "Winding Cove";
		public EuropeanDeadZoneWorld() : base(WORLD_NAME, NUMBER_OF_WORLD_REGION, WORLD_REGION_OUTSKIRTS) {
			AddWR(WORLD_REGION_WINDING);
			AddWR(WORLD_REGION_SUNKEN);
			AddWR(WORLD_REGION_FIREBASE);
			AddWR(WORLD_REGION_GULTCH);
			AddWR(WORLD_REGION_OUTSKIRTS);
			AddWR(WORLD_REGION_SLUDGE);
			AddWR(WORLD_REGION_TROSTLAND);
		}
	}
}
