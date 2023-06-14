namespace FishingZone.Worlds {
	internal class NessusWorld : WorldZone {
		private const string WORLD_NAME = "Nessus";
		private const int NUMBER_OF_WORLD_REGION = 7;
		private const string WORLD_REGION_CITERN = "The Citern";
		private const string WORLD_REGION_EXODUS = "Exodus Crash";
		private const string WORLD_REGION_TANGLE = "The Tangle";
		private const string WORLD_REGION_GLADE = "Glade of Echoes";
		private const string WORLD_REGION_HALLOWS = "Hallows";
		private const string WORLD_REGION_ARTIFACT = "Artifact's Edge";
		private const string WORLD_REGION_WATCHER = "Watcher's Grave";
		public NessusWorld() : base(WORLD_NAME, NUMBER_OF_WORLD_REGION, WORLD_REGION_CITERN) {
			AddWR(WORLD_REGION_CITERN);
			AddWR(WORLD_REGION_EXODUS);
			AddWR(WORLD_REGION_TANGLE);
			AddWR(WORLD_REGION_GLADE);
			AddWR(WORLD_REGION_HALLOWS);
			AddWR(WORLD_REGION_ARTIFACT);
			AddWR(WORLD_REGION_WATCHER);
		}
	}
}
