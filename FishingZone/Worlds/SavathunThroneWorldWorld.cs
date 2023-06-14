namespace FishingZone.Worlds {
	internal class SavathunThroneWorldWorld : WorldZone {

		private const string WORLD_NAME = "Savathûn Throne World";
		private const int NUMBER_OF_WORLD_REGION = 3;
		private const string WORLD_REGION_FLORESCENT = "Florescent Canal";
		private const string WORLD_REGION_MIASMA = "Miasma";
		private const string WORLD_REGION_QUAGMIRE = "Quagmire";
		public SavathunThroneWorldWorld() : base(WORLD_NAME, NUMBER_OF_WORLD_REGION, WORLD_REGION_FLORESCENT) {
			AddWR(WORLD_REGION_QUAGMIRE);
			AddWR(WORLD_REGION_MIASMA);
			AddWR(WORLD_REGION_FLORESCENT);
		}
	}
}
